using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectKLTN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectKLTN.ViewModels
{
    public class BlogCreateVM
    {
        public Blog Blog { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
        public IEnumerable<SelectListItem> TagSelectList { get; set; }
        public IEnumerable<int> SelectListTagIds { get; set; }

    }
}
