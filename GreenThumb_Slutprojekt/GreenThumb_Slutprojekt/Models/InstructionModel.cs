using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenThumb_Slutprojekt.Models
{
	public class InstructionModel
	{
		[Key]

		public int InstructionId { get; set; }



		public string Instructions { get; set; } = null!;

		public int PlantId { get; set; }

		public PlantModel Plant { get; set; } = null!;

		public InstructionModel()
		{

		}


	}
}
