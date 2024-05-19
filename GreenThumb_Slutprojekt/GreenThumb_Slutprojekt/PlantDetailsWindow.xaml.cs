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
	/// Interaction logic for PlantDetailsWindow.xaml
	/// </summary>
	public partial class PlantDetailsWindow : Window
	{

		//Deklarerar och sparat ett privat fält sparar informationen om den valda växten så denna kan användas i fönstret.
		private PlantModel selectedPlant;



		//Fyller i textboxen med instruktioner om den valda plantan från databasen
		public PlantDetailsWindow(PlantModel plantDetails)
		{

			InitializeComponent();
			txtPlant.Text = plantDetails.PlantName;
			selectedPlant = plantDetails;

			using (GreenThumbDb context = new())
			{
				var plantInstructions = context.Instructions.Where(plantInstruction => plantInstruction.PlantId == plantDetails.PlantId).ToList();

				txtInstructions.Text = string.Join(Environment.NewLine, plantInstructions.Select(pi => pi.Instructions));
			}

		}




		private void goBackBtn_Click(object sender, RoutedEventArgs e)
		{
			PlantWindow plantWindow = new PlantWindow();
			plantWindow.Show();
			this.Close();
		}

		private void txtPlant_TextChanged(object sender, TextChangedEventArgs e)
		{

		}
	}
}
