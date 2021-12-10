using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace PashaMarket.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public bool IsDelete { get; set; }
        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

    }
}
