using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using shesha.app.Domain.Domain;
using Shesha;
using Shesha.Domain;
using System;
using System.Threading.Tasks;

namespace shesha.app.Common.Services
{
    public class EmployeeEquipmentAppService : SheshaAppServiceBase
    {
        private readonly IRepository<Person, Guid> _personRepository;
        private readonly IRepository<Equipment, Guid> _equipmentRepository;
        private readonly IRepository<AccessRequest, Guid> _requestRepository;
        private readonly IRepository<ConditionReport, Guid> _reportRepository;

        public EmployeeEquipmentAppService(IRepository<Person, Guid> personRepository, IRepository<Equipment, Guid> equipmentRepository, IRepository<AccessRequest, Guid> requestRepository, IRepository<ConditionReport, Guid> reportRepository)
        {
            _personRepository = personRepository;
            _equipmentRepository = equipmentRepository;
            _requestRepository = requestRepository;
            _reportRepository = reportRepository;
        }

        [HttpGet, Route("[action]/{employeeId}")]
        public async Task<int> GetEquipmentCount(Guid employeeId)
        {
            var employee = await _personRepository.GetAsync(employeeId);
            if (employee == null)
                throw new Exception($"Employee with ID {employeeId} not found");
   

            var equipmentList = await _equipmentRepository.GetAllListAsync(e => e.Handler != null && e.Handler.Id == employeeId);
            return equipmentList.Count | 0;
        }
    }
}
