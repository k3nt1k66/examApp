using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using System.Collections.Generic;
using System.Reflection.Emit;


namespace WebApplication2.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<EmailAddress> EmailAddresses { get; set; }
        public DbSet<PersonPhone> PersonPhones { get; set; }
        public DbSet<PhoneNumberType> PhoneNumberTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasMany(p => p.EmailAddresses)
                .WithOne(e => e.Person)
                .HasForeignKey(e => e.PersonId);

            modelBuilder.Entity<Person>()
                .HasMany(p => p.PersonPhones)
                .WithOne(pp => pp.Person)
                .HasForeignKey(pp => pp.PersonId);

            modelBuilder.Entity<PhoneNumberType>()
                .HasMany(t => t.PersonPhones)
                .WithOne(pp => pp.PhoneNumberType)
                .HasForeignKey(pp => pp.PhoneNumberTypeId);
        }
    }
}