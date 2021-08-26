using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectKLTN.Models
{
    public class Showall
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool IsDeleted { get; set; }
        public int BlogId { get; set; }
        public string Image { get; set; }
        public DateTime PublishDate { get; set; }
        public string Title { get; set; }
        public string ShortContent { get; set; }
        public string FullContent { get; set; }
        public string TagName { get; set; }
    }
}
