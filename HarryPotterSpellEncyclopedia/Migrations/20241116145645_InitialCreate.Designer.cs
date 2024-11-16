﻿// <auto-generated />
using HarryPotterSpellEncyclopedia.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HarryPotterSpellEncyclopedia.Migrations
{
    [DbContext(typeof(SpellDbContext))]
    [Migration("20241116145645_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HarryPotterSpellEncyclopedia.Models.Spells", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Spells");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Disarming Charm",
                            Name = "Expelliarmus",
                            Type = "Charm"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Light Producing Charm",
                            Name = "Lumos",
                            Type = "Charm"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}