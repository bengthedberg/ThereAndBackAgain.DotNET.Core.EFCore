﻿// <auto-generated />
using System;
using InstantScratchIts.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InstantScratchIts.Web.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InstantScratchIts.Web.Data.InstantGame", b =>
                {
                    b.Property<int>("InstantGameId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameNo");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<decimal>("TicketAmount");

                    b.HasKey("InstantGameId");

                    b.ToTable("InstantGames");
                });

            modelBuilder.Entity("InstantScratchIts.Web.Data.Jurisdiction", b =>
                {
                    b.Property<int>("JurisdictionId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Allocation");

                    b.Property<int>("InstantGameId");

                    b.Property<string>("Name");

                    b.Property<decimal>("RetailCommissionAmount");

                    b.Property<DateTime>("StartSellDate");

                    b.Property<DateTime>("StopSellDate");

                    b.Property<TimeSpan>("ValidationPeriod");

                    b.HasKey("JurisdictionId");

                    b.HasIndex("InstantGameId");

                    b.ToTable("Jurisdiction");
                });

            modelBuilder.Entity("InstantScratchIts.Web.Data.Jurisdiction", b =>
                {
                    b.HasOne("InstantScratchIts.Web.Data.InstantGame")
                        .WithMany("Jurisdiction")
                        .HasForeignKey("InstantGameId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
