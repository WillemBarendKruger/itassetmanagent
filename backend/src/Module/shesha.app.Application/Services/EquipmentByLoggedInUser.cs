using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using shesha.app.Domain.Domain;
using Shesha.Domain;
using Shesha.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace shesha.app.Common.Services
{
    public class EquipmentByLoggedInUser : ShaSpecification<Equipment>
    {
            private readonly IAbpSession _abpSession;

            public EquipmentByLoggedInUser(
                IAbpSession abpSession)
            {
                _abpSession = abpSession;
            }

            public override Expression<Func<Equipment, bool>> BuildExpression()
            {
                var personRepo = IocManager.Resolve<IRepository<Person, Guid>>();
                var currentPerson = personRepo.GetAll().FirstOrDefault(p => p.User != null && p.User.Id == AbpSession.UserId);

                return equipmentItem => equipmentItem.Handler == currentPerson;
            }
    }
}
