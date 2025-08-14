using Shesha.Domain.Attributes;
using System.ComponentModel;

namespace shesha.app.Domain.Enums
{
    [ReferenceList("app", "RefListAccessRequestStatus")]
    public enum RefListAccessRequestStatus : long
    {
        [Description("Pending")]
        Pending = 1,

        [Description("Accepted")]
        Accepted = 2,

        [Description("Rejected")]
        Rejected = 3,
    }
}
