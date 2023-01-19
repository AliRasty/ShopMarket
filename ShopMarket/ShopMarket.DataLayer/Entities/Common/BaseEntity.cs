using System;
using System.ComponentModel.DataAnnotations;


namespace ShopMarket.DataLayer.Entities.Common
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }

        public bool IsDelete { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime LastUpdateDate { get; set; }
        
    }
}