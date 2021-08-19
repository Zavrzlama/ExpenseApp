using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpensesApp.Domain.Common
{
    public class AuditEntity
    {
        [Column("date_created")] public DateTime DateCreated { get; set; }
        [Column("date_updated")] public DateTime DateUpdated { get; set; }
    }
}