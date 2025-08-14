using Abp.Domain.Entities.Auditing;
using shesha.app.Domain.Enums;
using Shesha.Domain;
using Shesha.Domain.Attributes;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace shesha.app.Domain.Domain
{
    public class ConditionReport : FullAuditedEntity<Guid>
    {
        public virtual string Description { get; set; }

        [ReferenceList("app", "RefListConditionReportStatus")]
        public virtual RefListConditionReportStatus Status { get; set; } = RefListConditionReportStatus.Pending;

        //public virtual string ReportingEmployeeName { get; set; }rg

        [ForeignKey("EquipmentId")]
        public virtual Equipment EquipmentItem { get; set; }

        [ForeignKey("ReportingEmployeeId")]
        public virtual Person ReportingEmployee { get; set; }
    }
}
