using ProjectKLTN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectKLTN.ViewModels
{
    public class HomeIndexVM
    {
        public Blog Blog { get; set; }
        public Category Category { get; set; }
        public List<Blog> Blogs { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}
