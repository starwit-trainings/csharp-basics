using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using FootballManager.entities;
using Microsoft.Win32;

namespace FootballManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataFunctions df;
        public MainWindow()
        {
            InitializeComponent();
            df = new DataFunctions();
            Trace.WriteLine("initializing app");
        }

        private void ExitApplication_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void LoadData_Click(object sender, RoutedEventArgs e)
        {
            var folderDialog = new OpenFolderDialog
            {
                // Set options here
                Title = "Choose base folder"
            };

            if (folderDialog.ShowDialog() == true)
            {
                df.LoadData(folderDialog.FolderName);
            }
        }

        private void ShowClubs_Click(object sender, RoutedEventArgs e)
        {
            ClubList.ItemsSource = df.Clubs;
            ClubList.Visibility = Visibility.Visible;
        }
    }
}