using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using Shesha.Domain;
using Shesha.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace shesha.app.Domain.Domain
{
    public class AccessRequestbyLoggedinUser : ShaSpecification<AccessRequest>
    {
        //private readonly ICurrentUser _currentUser;
        private readonly IAbpSession _abpSession;
        public AccessRequestbyLoggedinUser(
            IAbpSession abpSession)
        {
            _abpSession = abpSession;
        }

        public override Expression<Func<AccessRequest, bool>> BuildExpression()
        {
            // Fetch current person. Note: all specifications are disabled here
            var personRepo = IocManager.Resolve<IRepository<Person, Guid>>();
            var currentPerson = personRepo.GetAll().FirstOrDefault(p => p.User != null && p.User.Id == AbpSession.UserId);

            // Return only persons from the same area as the current user
            return accessRequest => accessRequest.RequestingEmployee == currentPerson;
        }
    }
}
