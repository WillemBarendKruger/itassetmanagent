using FluentMigrator;
using Shesha.FluentMigrator;

namespace shesha.app.Domain.Migrations
{
    [Migration(20250814091100)]
    public class M20250814091100 : OneWayMigration
    {
        public override void Up()
        {
            Create.Table("app_ConditionReports")
                .WithIdAsGuid()
                .WithFullAuditColumns()

                .WithColumn("Description").AsString(int.MaxValue).NotNullable()
                .WithColumn("StatusLkp").AsInt32().NotNullable()

                .WithForeignKeyColumn("EquipmentId", "app_Equipments").Nullable()
                .WithForeignKeyColumn("ReportingEmployeeId", "Core_Persons").Nullable();
        }
    }

}

