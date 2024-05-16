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
    [Migration("20240516211711_InitialGreenThumb")]
    partial class InitialGreenThumb
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
                            Instructions = " Håll jorden jämnt fuktig, men låt inte växten stå i vatten. Vattna när det översta lagret av jord känns torrt.",
                            PlantId = 2
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
