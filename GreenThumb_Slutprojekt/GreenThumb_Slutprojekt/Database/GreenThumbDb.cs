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


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<PlantModel>().HasData(
			new PlantModel("Gullranka") { PlantId = 1 },
			new PlantModel("Peperomia") { PlantId = 2 }
			);

			modelBuilder.Entity<InstructionModel>().HasData(
				new InstructionModel
				{
					InstructionId = 1,
					InstructionName = "Vattning",
					Instructions = " Håll jorden jämnt fuktig, men låt inte växten stå i vatten. Vattna när det översta lagret av jord känns torrt.",
					PlantId = 1
				}
				);

		}


	}
}
