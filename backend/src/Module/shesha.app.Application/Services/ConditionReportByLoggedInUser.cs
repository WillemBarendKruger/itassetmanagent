using Abp.Domain.Repositories;
using Abp.Runtime.Session;
using shesha.app.Domain.Domain;
using Shesha.Domain;
using Shesha.Specifications;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace shesha.app.Common.Services
{
    public class ConditionReportByLoggedInUser : ShaSpecification<ConditionReport>
    {
        private readonly IAbpSession _abpSession;

        public ConditionReportByLoggedInUser(
            IAbpSession abpSession)
        {
            _abpSession = abpSession;
        }

        public override Expression<Func<ConditionReport, bool>> BuildExpression()
        {
            var personRepo = IocManager.Resolve<IRepository<Person, Guid>>();
            var currentPerson = personRepo.GetAll().FirstOrDefault(p => p.User != null && p.User.Id == AbpSession.UserId);

            return conditionReport => conditionReport.ReportingEmployee == currentPerson;
        }
    }
}
