using Shesha.Domain.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shesha.app.Domain.Enums
{
    [ReferenceList("app", "RefListConditionReportStatus")]
    public enum RefListConditionReportStatus : long
    {
        [Description("Pending")]
        Pending = 1,

        [Description("Accepted")]
        Accepted = 2,

        [Description("Rejected")]
        Rejected = 3,

        [Description("Maintenance")]
        Maintenance = 4,
    }
}
