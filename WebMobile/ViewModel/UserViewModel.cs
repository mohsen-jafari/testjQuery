using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMobile.ViewModel
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "پر کردن نام الزامی است")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "پر کردن نام خاموادگی الزامی است")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "پر کردن تاریخ تولد الزامی است")]
        
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "شماره تلفن وارد نشده است")]
        [Phone(ErrorMessage = "شماره تلفن  صحیح نیست")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "ایمیل وارد کنید")]
        [EmailAddress(ErrorMessage = "ایمیل را بصورت صحیح وارد کنید" )]
        public string Email { get; set; }
        
        public DateTime? RegisteryDate { get; set; }

        [Required(ErrorMessage = "پر کردن نام کاربری الزامی است")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "پر کردن گذرواژه الزامی است")]
        public string Password { get; set; }
        
        public bool IsAdmin { get; set; }
        public byte? Education { get; set; }
        public short? Country { get; set; }
        public string CountryName { get; set; }

    }
}