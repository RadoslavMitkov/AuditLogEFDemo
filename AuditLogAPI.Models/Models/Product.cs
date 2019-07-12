using System;
using System.ComponentModel.DataAnnotations;

namespace AuditLogAPI.Models
{
    public class Product : BaseEntity
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ExpirationDate { get; set; }
    }
}
