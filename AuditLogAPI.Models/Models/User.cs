using System.ComponentModel.DataAnnotations;

namespace AuditLogAPI.Models
{
    public class User : BaseEntity
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [Range(18, 50)]
        public int Age { get; set; }
    }
}
