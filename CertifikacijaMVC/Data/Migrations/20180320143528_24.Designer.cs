﻿// <auto-generated />
using CertifikacijaMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CertifikacijaMVC.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180320143528_24")]
    partial class _24
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CertifikacijaMVC.Models.ApplicationUser", b =>
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
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("CertifikacijaMVC.Models.Certifikat", b =>
                {
                    b.Property<int>("CertifikatId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumIzdavanja");

                    b.Property<string>("DjelovodniBroj")
                        .IsRequired();

                    b.Property<int?>("RezultatId");

                    b.HasKey("CertifikatId");

                    b.HasIndex("RezultatId");

                    b.ToTable("Certifikati");
                });

            modelBuilder.Entity("CertifikacijaMVC.Models.OdabirTipa", b =>
                {
                    b.Property<int>("OdabirTipaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PitanjeId");

                    b.Property<int>("TipPolaganjaId");

                    b.HasKey("OdabirTipaId");

                    b.HasIndex("PitanjeId");

                    b.HasIndex("TipPolaganjaId");

                    b.ToTable("OdabirTipa");
                });

            modelBuilder.Entity("CertifikacijaMVC.Models.OdgNaPitanje", b =>
                {
                    b.Property<int>("OdgNaPitanjeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("OdabirTipaId");

                    b.Property<int>("OdgovorId");

                    b.Property<int>("PitanjeId");

                    b.Property<bool>("Tačno");

                    b.Property<string>("TipOdgovora")
                        .IsRequired();

                    b.HasKey("OdgNaPitanjeId");

                    b.HasIndex("OdabirTipaId");

                    b.HasIndex("OdgovorId");

                    b.ToTable("OdgNaPitanjes");
                });

            modelBuilder.Entity("CertifikacijaMVC.Models.Odgovor", b =>
                {
                    b.Property<int>("OdgovorId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PitanjeId");

                    b.Property<string>("TekstOdgovora")
                        .IsRequired();

                    b.HasKey("OdgovorId");

                    b.HasIndex("PitanjeId");

                    b.ToTable("Odgovor");
                });

            modelBuilder.Entity("CertifikacijaMVC.Models.Pitanje", b =>
                {
                    b.Property<int>("PitanjeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("TekstPitanja");

                    b.HasKey("PitanjeId");

                    b.ToTable("Pitanje");
                });

            modelBuilder.Entity("CertifikacijaMVC.Models.Rezultat", b =>
                {
                    b.Property<int>("RezultatId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Bodovi");

                    b.Property<DateTime>("DatumPolaganja");

                    b.Property<int>("Pokusaj");

                    b.Property<int?>("TipPolaganjaId");

                    b.Property<string>("UserId");

                    b.HasKey("RezultatId");

                    b.HasIndex("TipPolaganjaId");

                    b.HasIndex("UserId");

                    b.ToTable("Rezultat");
                });

            modelBuilder.Entity("CertifikacijaMVC.Models.Test", b =>
                {
                    b.Property<int>("TestId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OdgovorId");

                    b.Property<int>("PitanjeId");

                    b.Property<int>("RezultatId");

                    b.HasKey("TestId");

                    b.HasIndex("OdgovorId");

                    b.HasIndex("PitanjeId");

                    b.HasIndex("RezultatId");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("CertifikacijaMVC.Models.TipPolaganja", b =>
                {
                    b.Property<int>("TipPolaganjaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Tip")
                        .IsRequired();

                    b.Property<string>("TipEng")
                        .IsRequired();

                    b.HasKey("TipPolaganjaId");

                    b.ToTable("TipPolaganja");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
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
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("CertifikacijaMVC.Models.Certifikat", b =>
                {
                    b.HasOne("CertifikacijaMVC.Models.Rezultat", "Rezultat")
                        .WithMany()
                        .HasForeignKey("RezultatId");
                });

            modelBuilder.Entity("CertifikacijaMVC.Models.OdabirTipa", b =>
                {
                    b.HasOne("CertifikacijaMVC.Models.Pitanje", "Pitanje")
                        .WithMany("OdabirTipas")
                        .HasForeignKey("PitanjeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CertifikacijaMVC.Models.TipPolaganja", "TipPolaganja")
                        .WithMany("OdabirTipas")
                        .HasForeignKey("TipPolaganjaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CertifikacijaMVC.Models.OdgNaPitanje", b =>
                {
                    b.HasOne("CertifikacijaMVC.Models.OdabirTipa", "OdabirTipa")
                        .WithMany("OdgNaPitanjes")
                        .HasForeignKey("OdabirTipaId");

                    b.HasOne("CertifikacijaMVC.Models.Odgovor", "Odgovor")
                        .WithMany("OdgNaPitanjes")
                        .HasForeignKey("OdgovorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CertifikacijaMVC.Models.Odgovor", b =>
                {
                    b.HasOne("CertifikacijaMVC.Models.Pitanje", "Pitanje")
                        .WithMany()
                        .HasForeignKey("PitanjeId");
                });

            modelBuilder.Entity("CertifikacijaMVC.Models.Rezultat", b =>
                {
                    b.HasOne("CertifikacijaMVC.Models.TipPolaganja", "TipPolaganja")
                        .WithMany()
                        .HasForeignKey("TipPolaganjaId");

                    b.HasOne("CertifikacijaMVC.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("CertifikacijaMVC.Models.Test", b =>
                {
                    b.HasOne("CertifikacijaMVC.Models.Odgovor", "Odgovor")
                        .WithMany("Testovi")
                        .HasForeignKey("OdgovorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CertifikacijaMVC.Models.Pitanje", "Pitanje")
                        .WithMany("Testovi")
                        .HasForeignKey("PitanjeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CertifikacijaMVC.Models.Rezultat", "Rezultat")
                        .WithMany("Testovi")
                        .HasForeignKey("RezultatId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CertifikacijaMVC.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CertifikacijaMVC.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CertifikacijaMVC.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CertifikacijaMVC.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
