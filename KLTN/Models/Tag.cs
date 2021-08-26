using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectKLTN.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        [Required(ErrorMessage = "Thẻ Tag")]
        public string TagName { get; set; }
        public List<BlogTag> BlogTags { get; set; }
    }
}
