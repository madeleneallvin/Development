using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using System.Data;

namespace Allvinskan.Booking.Migrations
{
    public class PartMigrations : DataMigrationImpl 
    {
        public int Create() {

            SchemaBuilder.CreateTable("ReservationPartRecord", t => t

                .ContentPartRecord()
                .Column("Duration", DbType.Int16)
                .Column("ReservationTime", DbType.DateTime)
            );

            ContentDefinitionManager.AlterPartDefinition("ReservationPart", part => part
                .Attachable());

            return 1;
        }

        public int UpdateFrom1()
        {
            SchemaBuilder.AlterTable("ReservationPartRecord", t => t
                .AddColumn("Customer_Id", DbType.Int16));
            SchemaBuilder.AlterTable("ReservationPartRecord", t => t
                .AddColumn("CustomerDesires", DbType.String));

            return 2;
        }

        public int UpdateFrom2()
        {
            SchemaBuilder.AlterTable("ReservationPartRecord", t => t
                .AddColumn("Status", DbType.Int16));

            return 3;
        }

        public int UpdateFrom3()
        {
            SchemaBuilder.AlterTable("ReservationPartRecord", t => t
                    .AddColumn("CustomerDesires", DbType.String));
            SchemaBuilder.AlterTable("ReservationPartRecord", t => t
                .AddColumn("Customer_Id", DbType.Int16));

            return 4;
        }
    }
}