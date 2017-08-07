using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SEOCRMTest.Models;
using SEOCRMTest.Models.WorkSpaceModels;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SEOCRMTest.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<DomainService>()
                .HasKey(c => new { c.DomainId, c.ServiceId });
            //foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            //{
            //    relationship.DeleteBehavior = DeleteBehavior.Restrict;
            //}

        }

        public DbSet<SEOCRMTest.Models.ApplicationUser> ApplicationUser { get; set; }

        public DbSet<Domain> Domain { get; set; }
        public DbSet<DomainAdminPanel> DomainAdminPanel { get; set; }       
        public DbSet<Owner> Owner { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<StatusDomain> StatusDomain { get; set; }
        public DbSet<TypeDomain> TypeDomain { get; set; }
        public DbSet<DomainService> DomainService { get; set; }

        public DbSet<Registrar> Registrar { get; set; }
        public DbSet<RegistrarAdminPanel> RegistrarAdminPanel { get; set; }
        public DbSet<RegistrarSupportPanel> RegistrarSupportPanel { get; set; }

        public DbSet<Server> Server { get; set; }
        public DbSet<ServerAdminPanel> ServerAdminPanel { get; set; }
        public DbSet<ServerSupportPanel> ServerSupportPanel { get; set; }

        public DbSet<Service> Service { get; set; }
        public DbSet<ServiceAdminPanel> ServiceAdminPanel { get; set; }
        public DbSet<ServiceSupportPanel> ServiceSupportPanel { get; set; }
    }
}
