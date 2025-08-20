using Abp.Domain.Entities;
using Shesha.Domain.Attributes;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace shesha.app.Domain.Domain
{
    [Table("vw_personsEquipment")]
    [ImMutable]
    public class PersonEquipment: Entity<Guid>
    {
        public virtual string FullName { get; set; }
        public virtual string EmailAddress1 { get; set; }
        public virtual int EquipmentCount { get; set; }
    }
}
