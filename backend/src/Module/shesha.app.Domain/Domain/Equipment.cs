using Abp.Domain.Entities.Auditing;
using shesha.app.Domain.Enums;
using Shesha.Domain;
using Shesha.Domain.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace shesha.app.Domain.Domain
{
    public class Equipment : FullAuditedEntity<Guid>
    {
        [Required]
        public virtual string Name { get; set; }

        [Required]
        public virtual string SerialNumber { get; set; }

        [Required]
        public virtual int MaintenancePeriodPerMonth { get; set; }

        [Required]
        [ReferenceList("app", "EquipmentStatus")]
        public virtual EquipmentStatus Status { get; set; } = EquipmentStatus.Inventory;


        public virtual DateTime? GetDate { get; set; }
        public virtual DateTime? ReturnDate { get; set; }
        public virtual DateTime? LastMaintenanceDate { get; set; }

        //public virtual Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        //public virtual long HandlerId { get; set; }
        [ForeignKey("HandlerId")]
        public virtual Person Handler { get; set; }
    }
}
