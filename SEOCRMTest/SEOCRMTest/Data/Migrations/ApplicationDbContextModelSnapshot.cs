using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SEOCRMTest.Data;

namespace SEOCRMTest.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SEOCRMTest.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.Domain", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("AdditionalInfo");

                    b.Property<int?>("DomainAdminPanelId");

                    b.Property<DateTimeOffset>("ExpiredDate");

                    b.Property<string>("IP");

                    b.Property<string>("MainDomain");

                    b.Property<string>("Name");

                    b.Property<int>("OwnerId");

                    b.Property<int>("ProjectId");

                    b.Property<string>("Redirect");

                    b.Property<int>("RegistrarId");

                    b.Property<int>("ServerId");

                    b.Property<int>("StatusDomainId");

                    b.Property<int>("TypeDomainId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("RegistrarId");

                    b.HasIndex("ServerId");

                    b.HasIndex("StatusDomainId");

                    b.HasIndex("TypeDomainId");

                    b.ToTable("Domain");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.DomainAdminPanel", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("DomainId");

                    b.Property<string>("Login");

                    b.Property<string>("Pass");

                    b.Property<string>("URL");

                    b.HasKey("Id");

                    b.ToTable("DomainAdminPanel");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.DomainService", b =>
                {
                    b.Property<int>("DomainId");

                    b.Property<int>("ServiceId");

                    b.HasKey("DomainId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("DomainService");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.Registrar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdditionalInfo");

                    b.Property<string>("Name");

                    b.Property<int>("RegistrarAdminPanelId");

                    b.Property<int?>("RegistrarSupportPanelId");

                    b.HasKey("Id");

                    b.ToTable("Registrar");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.RegistrarAdminPanel", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Login");

                    b.Property<string>("Pass");

                    b.Property<int>("RegistrarId");

                    b.Property<string>("URL");

                    b.HasKey("Id");

                    b.ToTable("RegistrarAdminPanel");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.RegistrarSupportPanel", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Login");

                    b.Property<string>("Pass");

                    b.Property<int>("RegistrarId");

                    b.Property<string>("URL");

                    b.HasKey("Id");

                    b.ToTable("RegistrarSupportPanel");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.Server", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdditionalInfo");

                    b.Property<DateTimeOffset>("ExpiredDate");

                    b.Property<string>("Name");

                    b.Property<int>("ServerAdminPanelId");

                    b.Property<int?>("ServerSupportPanelId");

                    b.HasKey("Id");

                    b.ToTable("Server");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.ServerAdminPanel", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Login");

                    b.Property<string>("Pass");

                    b.Property<int>("ServerId");

                    b.Property<string>("URL");

                    b.HasKey("Id");

                    b.ToTable("ServerAdminPanel");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.ServerSupportPanel", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Login");

                    b.Property<string>("Pass");

                    b.Property<int>("ServerId");

                    b.Property<string>("URL");

                    b.HasKey("Id");

                    b.ToTable("ServerSupportPanel");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdditionalInfo");

                    b.Property<DateTimeOffset>("ExpiredDate");

                    b.Property<string>("Name");

                    b.Property<int>("ServiceAdminPanelId");

                    b.Property<int?>("ServiceSupportPanelId");

                    b.HasKey("Id");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.ServiceAdminPanel", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Login");

                    b.Property<string>("Pass");

                    b.Property<int>("ServiceId");

                    b.Property<string>("URL");

                    b.HasKey("Id");

                    b.ToTable("ServiceAdminPanel");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.ServiceSupportPanel", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Login");

                    b.Property<string>("Pass");

                    b.Property<int>("ServiceId");

                    b.Property<string>("URL");

                    b.HasKey("Id");

                    b.ToTable("ServiceSupportPanel");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.StatusDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("StatusDomain");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.TypeDomain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TypeDomain");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SEOCRMTest.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SEOCRMTest.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId");

                    b.HasOne("SEOCRMTest.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.Domain", b =>
                {
                    b.HasOne("SEOCRMTest.Models.WorkSpaceModels.DomainAdminPanel", "DomainAdminPanel")
                        .WithMany()
                        .HasForeignKey("Id");

                    b.HasOne("SEOCRMTest.Models.WorkSpaceModels.Owner", "Owner")
                        .WithMany("Domains")
                        .HasForeignKey("OwnerId");

                    b.HasOne("SEOCRMTest.Models.WorkSpaceModels.Project", "Project")
                        .WithMany("Domains")
                        .HasForeignKey("ProjectId");

                    b.HasOne("SEOCRMTest.Models.WorkSpaceModels.Registrar", "Registrar")
                        .WithMany("Domains")
                        .HasForeignKey("RegistrarId");

                    b.HasOne("SEOCRMTest.Models.WorkSpaceModels.Server", "Server")
                        .WithMany("Domains")
                        .HasForeignKey("ServerId");

                    b.HasOne("SEOCRMTest.Models.WorkSpaceModels.StatusDomain", "StatusDomain")
                        .WithMany("Domains")
                        .HasForeignKey("StatusDomainId");

                    b.HasOne("SEOCRMTest.Models.WorkSpaceModels.TypeDomain", "TypeDomain")
                        .WithMany("Domains")
                        .HasForeignKey("TypeDomainId");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.DomainAdminPanel", b =>
                {
                    b.HasOne("SEOCRMTest.Models.WorkSpaceModels.Domain", "Domain")
                        .WithMany()
                        .HasForeignKey("Id");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.DomainService", b =>
                {
                    b.HasOne("SEOCRMTest.Models.WorkSpaceModels.Domain", "Domain")
                        .WithMany("DomainService")
                        .HasForeignKey("DomainId");

                    b.HasOne("SEOCRMTest.Models.WorkSpaceModels.Service", "Service")
                        .WithMany("DomainService")
                        .HasForeignKey("ServiceId");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.RegistrarAdminPanel", b =>
                {
                    b.HasOne("SEOCRMTest.Models.WorkSpaceModels.Registrar", "Registrar")
                        .WithOne("RegistrarAdminPanel")
                        .HasForeignKey("SEOCRMTest.Models.WorkSpaceModels.RegistrarAdminPanel", "Id");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.RegistrarSupportPanel", b =>
                {
                    b.HasOne("SEOCRMTest.Models.WorkSpaceModels.Registrar", "Registrar")
                        .WithOne("RegistrarSupportPanel")
                        .HasForeignKey("SEOCRMTest.Models.WorkSpaceModels.RegistrarSupportPanel", "Id");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.ServerAdminPanel", b =>
                {
                    b.HasOne("SEOCRMTest.Models.WorkSpaceModels.Server", "Server")
                        .WithOne("ServerAdminPanel")
                        .HasForeignKey("SEOCRMTest.Models.WorkSpaceModels.ServerAdminPanel", "Id");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.ServerSupportPanel", b =>
                {
                    b.HasOne("SEOCRMTest.Models.WorkSpaceModels.Server", "Server")
                        .WithOne("ServerSupportPanel")
                        .HasForeignKey("SEOCRMTest.Models.WorkSpaceModels.ServerSupportPanel", "Id");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.ServiceAdminPanel", b =>
                {
                    b.HasOne("SEOCRMTest.Models.WorkSpaceModels.Service", "Service")
                        .WithOne("ServiceAdminPanel")
                        .HasForeignKey("SEOCRMTest.Models.WorkSpaceModels.ServiceAdminPanel", "Id");
                });

            modelBuilder.Entity("SEOCRMTest.Models.WorkSpaceModels.ServiceSupportPanel", b =>
                {
                    b.HasOne("SEOCRMTest.Models.WorkSpaceModels.Service", "Service")
                        .WithOne("ServiceSupportPanel")
                        .HasForeignKey("SEOCRMTest.Models.WorkSpaceModels.ServiceSupportPanel", "Id");
                });
        }
    }
}
