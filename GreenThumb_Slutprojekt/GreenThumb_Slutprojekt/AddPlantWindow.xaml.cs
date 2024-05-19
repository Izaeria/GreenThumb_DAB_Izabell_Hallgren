using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using GreenThumb_Slutprojekt.Database;
using GreenThumb_Slutprojekt.Models;

namespace GreenThumb_Slutprojekt
{
	/// <summary>
	/// Interaction logic for AddPlantWindow.xaml
	/// </summary>
	public partial class AddPlantWindow : Window
	{
		public AddPlantWindow()
		{
			InitializeComponent();
		}


		//Kollar om alla fällt är ifyllda, kollar om växten redan finns i databasen och lägger till växten i databasen
		private void addPlantBtn_Click(object sender, RoutedEventArgs e)
		{
			//Kollar om alla fällt är ifyllda
			if (string.IsNullOrWhiteSpace(txtInstructions.Text) || string.IsNullOrWhiteSpace(txtPlantName.Text))
			{
				MessageBox.Show("Du måste skriva in både namn och instruktion för att lägga till en växt!");
			}

			else
			{
				using (var context = new GreenThumbDb())
				{
					string plantName = txtPlantName.Text.Trim();

					//Kollar om växten finns i databasen
					bool plantExists = context.Plants.Any(p => p.PlantName == plantName);


					if (plantExists)
					{
						MessageBox.Show("Växten finns redan i databasen!");
						return;
					}

					//Lägger till nya instruktioner för växten
					InstructionModel instruction = new InstructionModel
					{
						Instructions = txtInstructions.Text.Trim()
					};

					//Lägger till instruktionerna och namn 
					PlantModel newPlant = new PlantModel
					{
						PlantName = plantName,
						Instructions = new List<InstructionModel> { instruction }

					};

					//Lägger till växten i databasen
					context.Plants.Add(newPlant);
					context.SaveChanges();

					MessageBox.Show("Växten har lagts till i databasen!");
				}
			}
		}

		//Knapp för att gå tillbaka till föregående sida
		private void goBackBtn_Click(object sender, RoutedEventArgs e)
		{
			PlantWindow plantWindow = new PlantWindow();
			plantWindow.Show();
			this.Close();
		}

	}
}
