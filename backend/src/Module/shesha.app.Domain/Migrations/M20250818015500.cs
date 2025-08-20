using FluentMigrator;
using Shesha.FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shesha.app.Domain.Migrations
{
    [Migration(20250818015500)]
    public class M20250818015500 : OneWayMigration
    {
        public override void Up()
        {
            Execute.Sql(@"CREATE OR ALTER VIEW [dbo].[vw_personsEquipment]
                AS
                SELECT [Core_Persons].id,
                [Core_Persons].FullName, [Core_Persons].EmailAddress1, 
                count(app_Equipments.id) as EquipmentCount
                  FROM [dbo].[Core_Persons]
                  left outer join app_Equipments on Core_Persons.Id = app_Equipments.HandlerId
  
                  group by [Core_Persons].id,[Core_Persons].FullName, [Core_Persons].EmailAddress1
            ");
        }
    }
}
