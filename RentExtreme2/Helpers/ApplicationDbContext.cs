using Microsoft.AspNet.Identity.EntityFramework;
using RentExtreme2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace RentExtreme2.Helpers
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Firm> Firms { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<FirmsAddresses> FirmsAddresses { get; set; }
        public DbSet<FirmsServices> FirmsServices { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        //public override int SaveChanges()
        //{
        //    try
        //    {
        //        return base.SaveChanges();
        //    }
        //    catch (DbEntityValidationException e)
        //    {
        //        var newException = new FormattedDbEntityValidationException(e);
        //        throw newException;
        //    }
        //}

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //     //modelBuilder.Entity<Firm>().Map(u =>"UniqueName").IsUnique();

        //    //modelBuilder.Entity<Firm>().
        //    //    Property(t => t.UniqueName)
        //    //    .HasColumnAnnotation("Index",
        //    //    new IndexAnnotation(new IndexAttribute("UniqueName") { IsUnique = true }));
        //    //base.OnModelCreating(modelBuilder);
        //}
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}