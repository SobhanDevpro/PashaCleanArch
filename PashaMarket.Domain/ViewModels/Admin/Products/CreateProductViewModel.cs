using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PashaMarket.Domain.ViewModels.Admin.Products
{
    public class CreateProductViewModel
    {
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(300, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string Title { get; set; }

        [Display(Name = "توضیحات مختصر")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        [MaxLength(360, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد")]
        public string ShortDescription { get; set; }

        [Display(Name = "توضیحات اصلی")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public string Description { get; set; }

        [Display(Name = "قیمت")]
        [Required(ErrorMessage = "لطفا {0} را وارد نمایید")]
        public int Price { get; set; }

        public bool IsActive { get; set; }

        public IFormFile ProductImage { get; set; }

        public List<int> SelectedCategories { get; set; }
    }

    public enum CreateProductResult
    {
        Success,
        InvalidImage,
    }
}
