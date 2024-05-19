﻿// <auto-generated />
using GreenThumb_Slutprojekt.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GreenThumb_Slutprojekt.Migrations
{
    [DbContext(typeof(GreenThumbDb))]
    [Migration("20240519213105_GreenThummbTest3")]
    partial class GreenThummbTest3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GreenThumb_Slutprojekt.Models.InstructionModel", b =>
                {
                    b.Property<int>("InstructionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InstructionId"));

                    b.Property<string>("InstructionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instructions")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlantId")
                        .HasColumnType("int");

                    b.HasKey("InstructionId");

                    b.HasIndex("PlantId");

                    b.ToTable("Instructions");

                    b.HasData(
                        new
                        {
                            InstructionId = 1,
                            InstructionName = "Vattning",
                            Instructions = " Håll jorden jämnt fuktig, men låt inte växten stå i vatten. Vattna när det översta lagret av jord känns torrt.",
                            PlantId = 1
                        },
                        new
                        {
                            InstructionId = 2,
                            InstructionName = "Vattning",
                            Instructions = " Låt jorden torka något mellan vattningar. Undvik övervattning och låt inte växten stå i vatten.",
                            PlantId = 2
                        },
                        new
                        {
                            InstructionId = 3,
                            InstructionName = "Ljus",
                            Instructions = "Trivs bäst i indirekt solljus eller skuggiga områden.",
                            PlantId = 3
                        },
                        new
                        {
                            InstructionId = 4,
                            InstructionName = "Ljus",
                            Instructions = "Placera på en ljus plats med indirekt solljus.",
                            PlantId = 4
                        },
                        new
                        {
                            InstructionId = 5,
                            InstructionName = "Ljus",
                            Instructions = "Trivs i ljusa till delvis skuggiga områden.",
                            PlantId = 5
                        },
                        new
                        {
                            InstructionId = 6,
                            InstructionName = "Vattning",
                            Instructions = " Låt jorden torka något mellan vattningar. Undvik att övervattna.",
                            PlantId = 6
                        },
                        new
                        {
                            InstructionId = 7,
                            InstructionName = "Vattning",
                            Instructions = "Håll jorden fuktig, men undvik övervattning. Vattna när det översta lagret av jord känns torrt.",
                            PlantId = 7
                        },
                        new
                        {
                            InstructionId = 8,
                            InstructionName = "Vattning",
                            Instructions = " Håll jorden fuktig under sommaren och låt sedan torka något mellan vattningar under vintern.",
                            PlantId = 8
                        },
                        new
                        {
                            InstructionId = 9,
                            InstructionName = "Vattning",
                            Instructions = "Låt jorden torka helt mellan vattningar. Vattna sparsamt och undvik övervattning.",
                            PlantId = 9
                        },
                        new
                        {
                            InstructionId = 10,
                            InstructionName = "Ljus",
                            Instructions = "Trivs i ljusa till delvis skuggiga områden.",
                            PlantId = 10
                        });
                });

            modelBuilder.Entity("GreenThumb_Slutprojekt.Models.PlantModel", b =>
                {
                    b.Property<int>("PlantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlantId"));

                    b.Property<string>("PlantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlantId");

                    b.ToTable("Plants");

                    b.HasData(
                        new
                        {
                            PlantId = 1,
                            PlantName = "Gullranka"
                        },
                        new
                        {
                            PlantId = 2,
                            PlantName = "Peperomia"
                        },
                        new
                        {
                            PlantId = 3,
                            PlantName = "Fredskalla"
                        },
                        new
                        {
                            PlantId = 4,
                            PlantName = "Porslinsblomma"
                        },
                        new
                        {
                            PlantId = 5,
                            PlantName = "Syngonium"
                        },
                        new
                        {
                            PlantId = 6,
                            PlantName = "Monstera"
                        },
                        new
                        {
                            PlantId = 7,
                            PlantName = "Begonia"
                        },
                        new
                        {
                            PlantId = 8,
                            PlantName = "Ficus elastica "
                        },
                        new
                        {
                            PlantId = 9,
                            PlantName = "Aloe Vera"
                        },
                        new
                        {
                            PlantId = 10,
                            PlantName = "Tradescantia"
                        });
                });

            modelBuilder.Entity("GreenThumb_Slutprojekt.Models.InstructionModel", b =>
                {
                    b.HasOne("GreenThumb_Slutprojekt.Models.PlantModel", "Plant")
                        .WithMany("Instructions")
                        .HasForeignKey("PlantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plant");
                });

            modelBuilder.Entity("GreenThumb_Slutprojekt.Models.PlantModel", b =>
                {
                    b.Navigation("Instructions");
                });
#pragma warning restore 612, 618
        }
    }
}
