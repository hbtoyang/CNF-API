using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNFEFCore
{
    public class CNFDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<AmountType> AmountTypes { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<RecurringType> RecurringTypes { get; set; }
        public DbSet<DonationHistoryRecord> DonationHistoryRecords { get; set; }
        public DbSet<DonationException> DonationExceptions { get; set; }

        public CNFDbContext(DbContextOptions<CNFDbContext> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    string connStr = "Server=.;Database=CNF;Trusted_Connection=True;MultipleActiveResultSets=true";
        //    optionsBuilder.UseSqlServer(connStr);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

            modelBuilder.Entity<AmountType>().HasData(
                new AmountType { Id = 1, Amount = 25, Description = "$25" },
                new AmountType { Id = 2, Amount = 50, Description = "$50" },
                new AmountType { Id = 3, Amount = 75, Description = "$75" },
                new AmountType { Id = 4, Amount = 200, Description = "$200" }
            );
            modelBuilder.Entity<RecurringType>().HasData(
                new RecurringType { Id = 1, Name = "Monthly", Description = "Monthly" },
                new RecurringType { Id = 2, Name = "Quarterly", Description = "Quarterly" },
                new RecurringType { Id = 3, Name = "Yearly", Description = "Yearly" }
            );
        }
    }
}
