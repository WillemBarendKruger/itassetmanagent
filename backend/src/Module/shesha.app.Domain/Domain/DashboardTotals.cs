using Abp.Domain.Entities;
using Shesha.Domain.Attributes;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace shesha.app.Domain.Domain
{
    [Table("vw_SupervisorTotals")]
    [ImMutable]
    public class DashboardTotals : Entity<long>
    {
        public virtual int TotalPersons { get; set; }
        public virtual int TotalEquipment { get; set; }
        public virtual int TotalRequests { get; set; }
        public virtual int TotalReports { get; set; }
    }
}
