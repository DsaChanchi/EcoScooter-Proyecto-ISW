using EcoScooter.Entities;
using System;
using System.Data.Entity;
using System.Reflection;
using System.Linq;

namespace EcoScooter.Persistence
{
    public class EcoScooterDbContext : DbContextISW
    {
        public EcoScooterDbContext() : base("Name=EcoScooterDbConnection") //this is the connection string name
        {
            /*
            See DbContext.Configuration documentation
            */
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

        static EcoScooterDbContext()
        {
            //Database.SetInitializer<EcoScooterDbContext>(new CreateDatabaseIfNotExists<EcoScooterDbContext>());
            Database.SetInitializer<EcoScooterDbContext>(new DropCreateDatabaseIfModelChanges<EcoScooterDbContext>());
            //Database.SetInitializer<EcoScooterDbContext>(new DropCreateDatabaseAlways<EcoScooterDbContext>());
            //Database.SetInitializer<EcoScooterDbContext>(new EcoScooterDbContextInitializer());
            //Database.SetInitializer(new NullDatabaseInitializer<EcoScooterDbContext>());
        }

        // DbSets for persistent classes in your case study
        public DbSet<EcoScooter.Entities.EcoScooter> EcoScooters { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Incident> Incidents { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PlanningWork> PlanningWorks { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Scooter> Scooters { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<TrackPoint> TrackPoints { get; set; }
        public DbSet<User> Users { get; set; }





        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Primary keys with non conventional name
            /*
            modelBuilder.Entity<Person>().HasKey(p => p.Dni);
            modelBuilder.Entity<Customer>().HasKey(c => c.Dni);
            modelBuilder.Entity<CreditCard>().HasKey(c => c.Digits);
            */
            // Classes with more than one relationship
            /*
            modelBuilder.Entity<Reservation>().HasRequired(r => r.PickUpOffice).WithMany(o => o.PickUpReservations).WillCascadeOnDelete(false);
            modelBuilder.Entity<Reservation>().HasRequired(r => r.ReturnOffice).WithMany(o => o.ReturnReservations).WillCascadeOnDelete(false);
            */
        }

        // Generic method to clear all the data (except some relations if needed)

        // Sometimes it is needed to clear some relationships explicitly 
    }

}
