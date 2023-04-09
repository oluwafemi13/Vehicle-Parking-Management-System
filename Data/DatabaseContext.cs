using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Payment>().Property(x => x.AmountPaid).HasColumnType<decimal>("decimal").HasPrecision(18, 2);
            modelBuilder.Entity<Payment>().Property(x => x.AmountDue).HasColumnType<decimal>("decimal").HasPrecision(18, 2);

            /*modelBuilder.Entity<Vehicle>()
                                      .HasOne<VehicleCategory>(v => v.category)
                                      .WithOne(v => v.Vehicle)
                                      .OnDelete(DeleteBehavior.Cascade);*/
                                      


            modelBuilder.Entity<Booking>().HasOne<Payment>(p=> p.Payment)
                                      .WithOne(b=>b.Booking)
                                      .HasForeignKey<Payment>(b=>b.BookingId)
                                      .OnDelete(DeleteBehavior.Cascade);


        }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<ParkingSlot> Slots { get; set; }
        public DbSet<Payment> Payments { get; set; }
        //public DbSet<Role> Roles { get; set; }
        public DbSet<VehicleCategory> VehicleCategories { get; set; }
        public DbSet<VehicleOwner> VehicleOwners { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
       


    }
    
}
