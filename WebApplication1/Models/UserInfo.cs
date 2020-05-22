using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UserInfo
    {
        [Required(ErrorMessage ="وارد کردن نام الزامی است")]
        [Display(Name ="نام")]
        public string  FName { get; set; }
        [Required(ErrorMessage = "وارد کردن نام خانوادگی الزامی است")]
        [Display(Name = "نام خانوادگی")]
        public string  LName { get; set; }
        [Required(ErrorMessage = "وارد کردن سن کاربر الزامی است")]
        [Display(Name = "سن")]
        [Range(18,100,ErrorMessage ="حداقل سن 18 سال و بیشترین سن 100 سال می تواند باشد")]
        public int Age { get; set; }
        [Required(ErrorMessage = "وارد کردن تلفن تماس الزامی است")]
        [Display(Name = "تلفن")]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage = "وارد کردن ایمیل الزامی است")]
        [EmailAddress(ErrorMessage ="ایمیل را کامل و بع درستی وارد کنید")]
        [Display(Name = "ایمیل")]
        public string UserEmail { get; set; }

    }
}