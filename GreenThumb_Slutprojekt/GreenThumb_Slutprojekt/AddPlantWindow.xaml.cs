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

		private void addPlantBtn_Click(object sender, RoutedEventArgs e)
		{

		}

		private void goBackBtn_Click(object sender, RoutedEventArgs e)
		{
			PlantWindow plantWindow = new PlantWindow();
			plantWindow.Show();
			this.Close();
		}

	}
}
