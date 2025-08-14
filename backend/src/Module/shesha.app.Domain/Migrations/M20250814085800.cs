using FluentMigrator;
using Shesha.FluentMigrator;

namespace shesha.app.Domain.Migrations
{
    [Migration(20250814085800)]
    public class M20250814085800 : OneWayMigration
    {
        public override void Up()
        {
            Create.Table("app_AccessRequests")
                .WithIdAsGuid()
                .WithFullAuditColumns()

                .WithColumn("StatusLkp").AsInt32().NotNullable()
                .WithColumn("Description").AsString(int.MaxValue).Nullable()
                .WithColumn("GetDate").AsDateTime().Nullable()
                .WithColumn("ReturnDate").AsDateTime().Nullable()

                .WithForeignKeyColumn("EquipmentId", "app_Equipments").Nullable()
                .WithForeignKeyColumn("RequestingEmployeeId", "Core_Persons").Nullable();
        }

    }
}
