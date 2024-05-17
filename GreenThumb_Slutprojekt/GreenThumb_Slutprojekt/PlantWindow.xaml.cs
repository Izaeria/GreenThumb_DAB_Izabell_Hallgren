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
using GreenThumb_Slutprojekt.Repositories;

namespace GreenThumb_Slutprojekt
{
	/// <summary>
	/// Interaction logic for PlantWindow.xaml
	/// </summary>
	public partial class PlantWindow : Window
	{
		private List<PlantModel> getAllPlants;

		public PlantWindow()
		{
			InitializeComponent();




			LoadAllPlantsAsync();

			async void LoadAllPlantsAsync()
			{
				using (GreenThumbDb context = new())
				{
					PlantRepository<PlantModel> plantRepository = new(context);

					getAllPlants = await plantRepository.GetAll();

					foreach (var plant in getAllPlants)
					{
						ListViewItem item = new();
						item.Tag = plant;
						item.Content = plant.PlantName;
						lstPlants.Items.Add(item);
					}
				}
			}

		}

		//Filtrera växter enligt input i sökrutan
		private void txtSearchPlant_TextChanged(object sender, System.EventArgs e)
		{
			using (GreenThumbDb context = new())
			{
				var repository = new PlantRepository<PlantModel>(context);

				//User input
				string searchPlant = txtSearchPlant.Text.ToLower();

				lstPlants.Items.Clear();

				//Filtrerar växterna baserat på User Inpu
				var filteredPlant = getAllPlants.Where(p => p.PlantName.ToLower().Contains(searchPlant));

				foreach (var plant in filteredPlant)
				{
					ListViewItem item = new();
					item.Tag = plant;
					item.Content = plant.PlantName;
					lstPlants.Items.Add(item);
				}

			}
		}
		private void PlantDetailsBtn_Click(object sender, RoutedEventArgs e)
		{
			PlantDetailsWindow plantDetailsWindow = new PlantDetailsWindow();
			plantDetailsWindow.Show();
			Close();
		}

		private void DeletePlantBtn_Click(object sender, RoutedEventArgs e)
		{
			PlantDetailsWindow plantDetailsWindow = new PlantDetailsWindow();
			plantDetailsWindow.Show();
			Close();
		}
		private void AddPlantBtn_Click(object sender, RoutedEventArgs e)
		{
			PlantDetailsWindow plantDetailsWindow = new PlantDetailsWindow();
			plantDetailsWindow.Show();
			Close();
		}
	}
}
