using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectKLTN.Common;
using ProjectKLTN.Models;
using ProjectKLTN.ViewModels;

namespace ProjectKLTN.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BlogController(AppDbContext appDbContext, IWebHostEnvironment webHostEnvironment)
        {
            _appDbContext = appDbContext;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
         
            var products = _appDbContext.Blogs.Include(p => p.Category).ToList();

            return View(products);
        }

        public IActionResult Create()
        {
            BlogCreateVM productVM = new BlogCreateVM()
            {
                Blog = new Blog(),
                CategorySelectList = _appDbContext.Categories.Select(item => new SelectListItem
                {
                    Text = item.CategoryName,
                    Value = item.Id.ToString()
                }),
                TagSelectList = _appDbContext.Tags.Select(item => new SelectListItem
                {
                    Text = item.TagName,
                    Value = item.TagId.ToString()
                })
            };

            return View(productVM);
        }

        [HttpPost]
        public IActionResult Create(BlogCreateVM blogCreateVM)
        {
            
            var files = HttpContext.Request.Form.Files;
            string webRootPath = _webHostEnvironment.WebRootPath;

            string upload = webRootPath + CommonDefault.ImagePath;
            string fileName = Guid.NewGuid().ToString();
            string extension = Path.GetExtension(files[0].FileName);

            using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
            {
                files[0].CopyTo(fileStream);
            }

            blogCreateVM.Blog.Image = fileName + extension;

            
                foreach (var item in blogCreateVM.SelectListTagIds)
            {
                if (ModelState.IsValid)
                {
                    blogCreateVM.Blog.BlogTags.Add(new BlogTag()
                {
                    TagId = item
                });
            }

            _appDbContext.Blogs.Add(blogCreateVM.Blog);

            _appDbContext.SaveChanges();

            return RedirectToAction("Index");
            }
            return View(blogCreateVM);
        }



        public IActionResult Edit(int? id)
        {
            var product = _appDbContext.Blogs.Find(id);
            var tags = _appDbContext.Tags.ToList();
            var selectTags = product.BlogTags.Select(x => new Tag()
            {
                TagId = x.Tag.TagId,
                TagName = x.Tag.TagName
            });
            var selectList = new List<SelectListItem>();
            tags.ForEach(i => selectList.Add(new SelectListItem(i.TagName, i.TagId.ToString(), selectTags.Select(x => x.TagId).Contains(i.TagId))));
            BlogCreateVM productVM = new BlogCreateVM()
            {
                Blog = _appDbContext.Blogs.FirstOrDefault(item => item.Id == id),
                CategorySelectList = _appDbContext.Categories.Select(item => new SelectListItem
                {
                    Text = item.CategoryName,
                    Value = item.Id.ToString()
                }),
                TagSelectList = selectList
                /* SelectListTagIds = Product..Select(sc => sc.CourseId)*/
            };

            return View(productVM);
        }

        [HttpPost]
        public IActionResult Edit(BlogCreateVM blogCreateVM)
        {
            var files = HttpContext.Request.Form.Files;
            string webRootPath = _webHostEnvironment.WebRootPath;

            var objBlog = _appDbContext.Blogs.AsNoTracking().FirstOrDefault(pro => pro.Id == blogCreateVM.Blog.Id);

            if (files.Count > 0)
            {
                string upload = webRootPath + CommonDefault.ImagePath;
                string fileName = Guid.NewGuid().ToString();
                string extension = Path.GetExtension(files[0].FileName);

                using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }

                blogCreateVM.Blog.Image = fileName + extension;
            } else
            {
                blogCreateVM.Blog.Image = objBlog.Image;
            }

            _appDbContext.Blogs.Update(blogCreateVM.Blog);
            _appDbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var blog = _appDbContext.Blogs.Find(id);
            if (blog == null) return NotFound();

            return View(blog);
        }

        [HttpPost]
        public IActionResult DeleteBlog(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var blogs = _appDbContext.Blogs.Find(id);
            if (blogs == null) return NotFound();
            _appDbContext.Blogs.Remove(blogs);
            _appDbContext.SaveChanges();

            return RedirectToAction("Index");

        }

        
    }
}
