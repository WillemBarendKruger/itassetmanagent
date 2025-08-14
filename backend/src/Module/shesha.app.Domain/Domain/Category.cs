using Abp.Domain.Entities;
using System;

namespace shesha.app.Domain.Domain
{
    public class Category : Entity<Guid>
    {
       public virtual string Name { get; set; }
    }
}
