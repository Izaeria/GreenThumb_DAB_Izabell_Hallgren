using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GreenThumb_Slutprojekt.Models;
using Microsoft.EntityFrameworkCore;

namespace GreenThumb_Slutprojekt.Database
{
	internal class GreenThumbDb : DbContext
	{

		//Definitioner av properties 
		public DbSet<InstructionModel> Instructions { get; set; }
		public DbSet<PlantModel> Plants { get; set; }

		//Connection String
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

			optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database =GreenThumbDb;Trusted_Connection=True;");
		}

		//Seedar databasen med plantor
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<PlantModel>().HasData(
			new PlantModel("Gullranka") { PlantId = 1 },
			new PlantModel("Peperomia") { PlantId = 2 },
			new PlantModel("Fredskalla") { PlantId = 3 },
			new PlantModel("Porslinsblomma") { PlantId = 4 },
			new PlantModel("Syngonium") { PlantId = 5 },
			new PlantModel("Monstera") { PlantId = 6 },
			new PlantModel("Begonia") { PlantId = 7 },
			new PlantModel("Ficus elastica ") { PlantId = 8 },
			new PlantModel("Aloe Vera") { PlantId = 9 },
			new PlantModel("Tradescantia") { PlantId = 10 }
			);

			modelBuilder.Entity<InstructionModel>().HasData(
				new InstructionModel()
				{
					InstructionId = 1,
					InstructionName = "Vattning",
					Instructions = " Håll jorden jämnt fuktig, men låt inte växten stå i vatten. Vattna när det översta lagret av jord känns torrt.",
					PlantId = 1,
				},
				new InstructionModel()
				{
					InstructionId = 2,
					InstructionName = "Vattning",
					Instructions = " Låt jorden torka något mellan vattningar. Undvik övervattning och låt inte växten stå i vatten.",
					PlantId = 2,
				},
				new InstructionModel()
				{
					InstructionId = 3,
					InstructionName = "Ljus",
					Instructions = "Trivs bäst i indirekt solljus eller skuggiga områden.",
					PlantId = 3,
				},
				new InstructionModel()
				{
					InstructionId = 4,
					InstructionName = "Ljus",
					Instructions = "Placera på en ljus plats med indirekt solljus.",
					PlantId = 4,
				},
					new InstructionModel()
					{
						InstructionId = 5,
						InstructionName = "Ljus",
						Instructions = "Trivs i ljusa till delvis skuggiga områden.",
						PlantId = 5,
					},
					new InstructionModel()
					{
						InstructionId = 6,
						InstructionName = "Vattning",
						Instructions = " Låt jorden torka något mellan vattningar. Undvik att övervattna.",
						PlantId = 6,
					},
					new InstructionModel()
					{
						InstructionId = 7,
						InstructionName = "Vattning",
						Instructions = "Håll jorden fuktig, men undvik övervattning. Vattna när det översta lagret av jord känns torrt.",
						PlantId = 7,
					},
					new InstructionModel()
					{
						InstructionId = 8,
						InstructionName = "Vattning",
						Instructions = " Håll jorden fuktig under sommaren och låt sedan torka något mellan vattningar under vintern.",
						PlantId = 8,
					},
					new InstructionModel()
					{
						InstructionId = 9,
						InstructionName = "Vattning",
						Instructions = "Låt jorden torka helt mellan vattningar. Vattna sparsamt och undvik övervattning.",
						PlantId = 9,
					},
					new InstructionModel()
					{
						InstructionId = 10,
						InstructionName = "Ljus",
						Instructions = "Trivs i ljusa till delvis skuggiga områden.",
						PlantId = 10,
					}


				);

		}


	}
}
