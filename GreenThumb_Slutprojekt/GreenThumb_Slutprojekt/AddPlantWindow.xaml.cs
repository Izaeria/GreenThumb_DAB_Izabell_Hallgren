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
				MessageBox.Show("You need to write the name and instrictions to add a plant!");

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
						MessageBox.Show("This plant already exists in the database!");
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

					MessageBox.Show("Plant added to database!");
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
