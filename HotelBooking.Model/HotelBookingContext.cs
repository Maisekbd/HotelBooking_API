using Repository.Pattern.Ef6;
using System;
using System.Collections.Generic;
using System.Data.Entity;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking.Model
{
    public partial class HotelBookingContext : DataContext
    {
        public HotelBookingContext() : base("Name=HotelBookingDBConnectionString")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<HotelBookingContext, MigrateConfiguration>("FlavourManagementContext"));
            //this.Configuration.LazyLoadingEnabled = false;
            //this.Configuration.ProxyCreationEnabled = false;
        }
        //"name= HotelBookingDBConnectionString"


        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<HotelReservation> HotelReservations { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=HotelBooking;User ID=sa;Password=P@ssw0rd;;MultipleActiveResultSets=True");
        //    }
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Hotel>(entity =>
        //    {
        //        entity.HasKey(e => e.Id);
        //    });
        //    modelBuilder.Entity<Customer>(entity =>
        //    {
        //        entity.HasKey(e => e.ID);
        //    });
        //    modelBuilder.Entity<HotelReservation>(entity =>
        //    {
        //        entity.HasKey(e => e.Id);
        //    });
        //}

    }


    //public class HotelBookingContextFactory : IDesignTimeDbContextFactory<HotelBookingContext>
    //{
    //    public HotelBookingContext CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<HotelBookingContext>();
    //        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=HotelBooking;User ID=sa;Password=P@ssw0rd;;MultipleActiveResultSets=True");
    //        return new HotelBookingContext(optionsBuilder.Options);
    //    }
    //}
}
