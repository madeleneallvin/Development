using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using System.Data;

namespace Allvinskan.Booking.Migrations
{
    public class TypeMigrations : DataMigrationImpl
    {
        public int Create()
        {
            ContentDefinitionManager.AlterTypeDefinition("Reservation", cfg => cfg
                .Creatable()
                .WithPart("ReservationPart")
                .WithPart("CommonPart")
                .WithPart("AutoRoutePart")
            );

            return 1;
        }
        public int UpdateFrom1()
        {
            ContentDefinitionManager.AlterTypeDefinition("Reservation", cfg => cfg
            .WithPart("AutoroutePart", builder => builder
                        .WithSetting("AutorouteSettings.AllowCustomPattern", "true")
                        .WithSetting("AutorouteSettings.AutomaticAdjustmentOnEdit", "false")
                        .WithSetting("AutorouteSettings.PatternDefinitions", "[{Name:'Title', Pattern: '{Content.Slug}', Description: 'reservation'}]")
                        .WithSetting("AutorouteSettings.DefaultPatternIndex", "0")));

            return 2;
        }
    }
}