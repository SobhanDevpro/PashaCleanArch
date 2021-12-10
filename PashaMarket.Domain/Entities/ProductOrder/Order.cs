using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PashaMarket.Domain.Entities.Account;
using PashaMarket.Domain.Entities.Base;

namespace PashaMarket.Domain.Entities.ProductOrder
{
    public class Order : BaseEntity
    {
        #region properties

        public int UserId { get; set; }

        public bool IsPay { get; set; }
        [Display(Name = "تاریخ پرداخت")]
        public DateTime? PaymentDate { get; set; }

        [Display(Name = "قیمت کل")]
        public int TotalPrice { get; set; }

        [Display(Name = "کد پیگیری")]
        [MaxLength(300, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر داشته باشد")]
        public string Recipient { get; set; }

        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        #endregion

        #region Relations
        public User User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

        #endregion
    }
}
