using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectKLTN.Models
{
    public class About
    {
        [Required(ErrorMessage = "Nhập Title!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Nhập ShortContent!")]
        public string ShortContent { get; set; }

        [Required(ErrorMessage = "Nhập FullContent!")]
        public string FullContent { get; set; }
    }
}
