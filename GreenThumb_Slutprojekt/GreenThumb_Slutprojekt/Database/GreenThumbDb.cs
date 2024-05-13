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
			optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database =GreenThumbDb;Trusted_Connection=True;");
		}

	}
}
