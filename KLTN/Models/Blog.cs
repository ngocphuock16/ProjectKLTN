using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectKLTN.Models
{
    public class Blog
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "Image trống!")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Nhập PublishDate!")]
        public DateTime PublishDate { get; set; }

        [Required(ErrorMessage = "Nhập Title!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Nhập ShortContent!")]
        public string ShortContent { get; set; }

        [Required(ErrorMessage = "Nhập FullContent!")]
        public string FullContent { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<BlogTag> BlogTags { get; set; } = new List<BlogTag>();
    }
}
