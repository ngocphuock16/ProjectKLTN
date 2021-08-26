using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectKLTN.Areas.Identity.Data;
using ProjectKLTN.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectKLTN.Models
{
    public class AppDbContext : IdentityDbContext<ProjectKLTNUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }


     
       /* public Blog[] Get() => Blogs.ToArray();

        public Blog[] Get(string search)
        {
            var s = search.ToLower();
            return Blogs.Where(b =>
                b.Title.ToLower().Contains(s) ||
                b.ShortContent.ToLower().Contains(s) ||
                b.FullContent.ToLower().Contains(s) ||
                b.Category.CategoryName.ToLower() ==s
            ).ToArray();
        }*/


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Internet" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Bảo mật" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Sản phẩm công nghệ" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 4, CategoryName = "Mẹo hay" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 5, CategoryName = "Thủ thuật" });
            modelBuilder.Entity<BlogTag>().HasKey(protag => new { protag.BlogId, protag.TagId });

            modelBuilder.Entity<About>().HasNoKey();

            //Seeder data tag
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                TagId = 1,
                TagName = "Tin tức mới"
            });
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                TagId = 2,
                TagName = "Tin tức hay"
            });
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                TagId = 3,
                TagName = "Tin tức hot"
            });
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                TagId = 4,
                TagName = "Iphone"
            });
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                TagId = 5,
                TagName = "Thương mại điện tử"
            });
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                TagId = 6,
                TagName = "Robot"
            });
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                TagId = 7,
                TagName = "Google"
            });
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                TagId = 8,
                TagName = "Facebook"
            });
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                TagId = 9,
                TagName = "Samsung"
            });
            modelBuilder.Entity<Tag>().HasData(new Tag
            {
                TagId = 10,
                TagName = "Smartphone"
            });
        }
    }
}
