using FluentMigrator;
using Shesha.FluentMigrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shesha.app.Domain.Migrations
{
    [Migration(20250814075800)]
    public class M20250814075800 : OneWayMigration
    {
        public override void Up()
        {
            Create.Table("app_Categories")
                .WithIdAsGuid()
                .WithColumn("Name").AsString(255).NotNullable();


            Create.Table("app_Equipments")
                .WithIdAsGuid()
                .WithFullAuditColumns()
                .WithColumn("Name").AsString(255).NotNullable()
                .WithColumn("SerialNumber").AsString(255).NotNullable()
                .WithColumn("MaintenancePeriodPerMonth").AsInt32().NotNullable()
                .WithColumn("StatusLkp").AsInt32().NotNullable()
                .WithColumn("GetDate").AsDateTime().Nullable()
                .WithColumn("ReturnDate").AsDateTime().Nullable()
                .WithColumn("LastMaintenanceDate").AsDateTime().Nullable()
                .WithForeignKeyColumn("CategoryId", "app_Categories").Nullable()
                .WithForeignKeyColumn("HandlerId", "Core_Persons").Nullable();


        }
    }
}
