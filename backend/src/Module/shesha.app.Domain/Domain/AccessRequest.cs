using Abp.Domain.Entities.Auditing;
using shesha.app.Domain.Enums;
using Shesha.Domain;
using Shesha.Domain.Attributes;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace shesha.app.Domain.Domain
{
    public class AccessRequest : FullAuditedEntity<Guid>
    {
        [ReferenceList("app", "RefListAccessRequestStatus")]
        public virtual RefListAccessRequestStatus Status { get; set; } = RefListAccessRequestStatus.Pending;

        public virtual string? Description { get; set; }

        public virtual DateTime? GetDate { get; set; }

        public virtual DateTime? ReturnDate { get; set; }

        [ForeignKey("EquipmentId")]
        public virtual Equipment EquipmentItem { get; set; }

        [ForeignKey("RequestingEmployeeId")]
        public virtual Person RequestingEmployee { get; set; }
    }
}
