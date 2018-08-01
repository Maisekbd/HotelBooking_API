using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Model.Migrations
{
    public sealed class MigrateConfiguration : DbMigrationsConfiguration<HotelBookingContext>
    {
        public MigrateConfiguration()
        {

            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

        }

    }
}
