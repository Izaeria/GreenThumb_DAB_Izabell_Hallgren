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

			//Metod som laddar alla växter i databasen
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

				//Filtrerar växterna baserat på User Input
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

		//Visar den valda växtens information i ett nytt fönster
		private void PlantDetailsBtn_Click(object sender, RoutedEventArgs e)
		{

			if (lstPlants.SelectedItem != null)
			{
				ListViewItem selectedItem = new ListViewItem();
				selectedItem = (ListViewItem)lstPlants.SelectedItem;
				PlantModel selectedPlant = (PlantModel)selectedItem.Tag;

				PlantDetailsWindow plantDetailsWindow = new PlantDetailsWindow(selectedPlant);
				plantDetailsWindow.Show();
				Close();
			}

		}

		//Tar bort en växt
		private void DeletePlantBtn_Click(object sender, RoutedEventArgs e)
		{
			if (lstPlants.SelectedItem != null)
			{
				ListViewItem selectedPlant = (ListViewItem)lstPlants.SelectedItem;
				PlantModel removePlant = (PlantModel)selectedPlant.Tag;
				MessageBoxResult answer = MessageBox.Show($"Are you sure you want to delete this plant?", "Delete Confirmation", MessageBoxButton.YesNo);

				if (answer == MessageBoxResult.Yes)
				{
					//Ta bort växten från listan
					lstPlants.Items.Remove(lstPlants.SelectedItem);


					//Ta bort växten från databasen
					using (GreenThumbDb context = new())
					{
						PlantRepository<PlantModel> plantRepository = new(context);
						plantRepository.Delete(removePlant);
						MessageBox.Show($"Plant has been deleted!");
					}
				}
			}
			else
			{
				MessageBox.Show("You need to select a plant to delete!");
			}

		}

		//Öppnar AddPlantWindows för att lägga till en ny växt
		private void AddPlantBtn_Click(object sender, RoutedEventArgs e)
		{
			AddPlantWindow addPlantWindow = new AddPlantWindow();
			addPlantWindow.Show();
			Close();
		}
	}
}
