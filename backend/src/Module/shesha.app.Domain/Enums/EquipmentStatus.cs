using Shesha.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shesha.app.Domain.Enums
{
    [ReferenceList("app","EquipmentStatus")]
    public enum EquipmentStatus : long
    {
        [Description("Inventory")]
        Inventory = 1,

        [Description("Booked")]
        Booked = 2,

        [Description("Maintenance")]
        Maintenance = 3,
    }
}
