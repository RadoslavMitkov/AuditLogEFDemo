using System;

namespace AuditLogAPI.Models
{
    public class AuditLog
    {
        public int Id { get; set; }

        public string AuditData { get; set; }

        public string EntityType { get; set; }

        public DateTime AuditDate { get; set; }

        public string TablePk { get; set; }
    }
}
