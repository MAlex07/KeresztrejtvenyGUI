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

namespace KeresztrejtvenyGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for(int i = 6; i<=15; i++)
            {
                cb_sorokszama.Items.Add(i);
                cb_oszlopokszama.Items.Add(i);
			}

            for (int i = 1; i<=10; i++)
            {
                cb_index.Items.Add(i);
			}

            cb_oszlopokszama.SelectedItem = 15;
            cb_sorokszama.SelectedItem = 15;
            cb_index.SelectedItem = 3;


		}
    }
}