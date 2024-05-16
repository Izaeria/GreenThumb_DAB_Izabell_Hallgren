using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenThumb_Slutprojekt.Models
{
	internal class PlantModel
	{
		[Key]

		public int PlantId { get; set; }

		public string PlantName { get; set; } = null!;


		public List<InstructionModel> Instructions { get; set; } = new();

		public PlantModel(string plantName)
		{
			PlantName = plantName;
		}


		public PlantModel(string plantName, int plantId, List<InstructionModel> instructions)
		{

			PlantName = plantName;
			PlantId = plantId;
			Instructions = instructions;
		}
	}
}
