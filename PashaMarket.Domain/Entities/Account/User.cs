using System;
using System.ComponentModel.DataAnnotations;
using PashaMarket.Domain.Entities.Base;

namespace PashaMarket.Domain.Entities.Account
{
    public class User : BaseEntity
    {
        #region properties

        [Display(Name = "نام")]

        [MaxLength(150, ErrorMessage = "نام وارد شده نمی تواند بیشتر از 150 کاراکتر باشد")]
        public string FirstName { get; set; }


        [Display(Name = "نام خانوادگی")]

        [MaxLength(150, ErrorMessage = "نام خانوادگی وارد شده نمی تواند بیشتر از 150 کاراکتر باشد")]
        public string LastName { get; set; }


        [Display(Name = "ایمیل")]
        [MaxLength(150, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر داشته باشد")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نمی باشد")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string EmailActiveCode { get; set; }


        [Display(Name = "ایمیل فعال / غیرفعال")]
        public bool IsEmailActive { get; set; }


        [Display(Name = "تلفن همراه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Mobile { get; set; }


        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(20, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string MobileActiveCode { get; set; }


        [Display(Name = "موبایل فعال / غیرفعال")]
        public bool IsMobileActive { get; set; }


        [Display(Name = "کلمه ی عبور")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر داشته باشد")]
        public string Password { get; set; }


        [Display(Name = "تصویر آواتار")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد")]
        public string Avatar { get; set; }


        [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string ActiveCode { get; set; }


        public bool IsActive { get; set; }


        public bool IsSuperUser { get; set; }


        [Display(Name = "بلاک شده / نشده")]
        public bool IsBlocked { get; set; }

        #endregion

        #region relations



        #endregion
    }
}
