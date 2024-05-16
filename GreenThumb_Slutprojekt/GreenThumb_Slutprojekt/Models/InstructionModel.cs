using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenThumb_Slutprojekt.Models
{
	internal class InstructionModel
	{
		[Key]

		public int InstructionId { get; set; }

		public string? InstructionName { get; set; }

		public string Instructions { get; set; } = null!;

		public int PlantId { get; set; }

		public PlantModel Plant { get; set; } = null!;

		public InstructionModel()
		{

		}

		public InstructionModel(int instructionId, string instructionName, string instructions, int plantId, PlantModel plant)
		{
			InstructionId = instructionId;
			InstructionName = instructionName;
			Instructions = instructions;
			PlantId = plantId;
			Plant = plant;
		}
	}
}
