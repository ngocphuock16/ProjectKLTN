using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectKLTN.Models
{
    public class Contact
    {
        [Key, Column(Order = 1)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Nhập tên đầy đủ của bạn!")]
        [MinLength(3, ErrorMessage = "Tên phải có tối thiếu 3 ký tự!")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ email của bạn!")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email không đúng định dạng!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Nhập nội dung cần hỗ trợ!")]
        [MinLength(20, ErrorMessage = "Nội dung hỗ trợ phải có 20 ký tự trở lên!")]
        public string SupportContent { get; set; }
    }
}
