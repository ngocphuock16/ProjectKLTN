using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectKLTN.Models;
using ProjectKLTN.ViewModels;

namespace ProjectKLTN.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _appDbContext;
        private readonly XmlSerializer _serializer = new XmlSerializer(typeof(HashSet<Blog>));
        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {

            _logger = logger;
            _appDbContext = appDbContext;
        }

        /*public IActionResult Index()
        {

            List<Blog> blogs = _appDbContext.Blogs.ToList();
            List<Category> categories = _appDbContext.Categories.ToList();
            List<Showall> showalls = (from s in blogs
                                      join c in categories on s.CategoryId equals c.CategoryId
                                      where c.IsDeleted == false && s.IsDeleted == false
                                      select (new Showall()
                                      {
                                          CategoryId = s.CategoryId,
                                          BlogId = s.BlogId,
                                          Title = s.Title,
                                          Image = s.Image,
                                          CategoryName = c.CategoryName,
                                          ShortContent = s.ShortContent,
                                          PublishDate = s.PublishDate,
                                          FullContent = s.FullContent,
                                          IsDeleted = s.IsDeleted
                                      })).ToList();


            return View(showalls);
        }*/

        public IActionResult Index()
        {
            HomeIndexVM homeIndexVM = new HomeIndexVM()
            {
                Blogs = _appDbContext.Blogs.Include(p => p.Category).ToList(),
                Categories = _appDbContext.Categories
            };
            return View(homeIndexVM);
        }

      /*  public IActionResult Index()
        {
            IEnumerable<Blog> blogs = _appDbContext.Blogs.Include(p => p.Category);

            return View(blogs);
        }*/

        public IActionResult Details(int id)
        {
            var blogs = _appDbContext.Blogs.Find(id);
            List<Category> categories = _appDbContext.Categories.ToList();
            ViewBag.ListRelatedBlogs = _appDbContext.Blogs.Where(x => x.Id != id && x.CategoryId == blogs.CategoryId).ToList();
            if (blogs == null) return NotFound();
            else return View(blogs);
        }


      /*  public IActionResult Search(string term)
        {
            return View("Index", _appDbContext.Get(term));
        }*/


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
