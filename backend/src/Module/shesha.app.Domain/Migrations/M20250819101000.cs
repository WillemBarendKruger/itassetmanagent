using FluentMigrator;
using Shesha.FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shesha.app.Domain.Migrations
{
    [Migration(20250819101000)]
    public class M20250819101000 : OneWayMigration
    {
        public override void Up()
        {
            Execute.Sql(@"
                CREATE OR ALTER VIEW [dbo].[vw_SupervisorTotals]
                AS
                SELECT 
                1 AS Id,
                count([app_Equipments].id) as TotalEquipment,
                count([app_AccessRequests].Id) as TotalRequests, 
                count([app_ConditionReports].id) as TotalReports, 
                count([Core_Persons].id) as TotalPersons

                FROM Core_Persons
                    left join app_Equipments on HandlerId = Core_Persons.Id
                    left join app_AccessRequests on RequestingEmployeeId = Core_Persons.Id
                    left join app_ConditionReports on ReportingEmployeeId = Core_Persons.Id  
            ");
        }
    }
}
