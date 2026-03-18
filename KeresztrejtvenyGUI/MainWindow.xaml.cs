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

		private void btn_letrehoz_Click(object sender, RoutedEventArgs e)
		{
            for(int i = 0; i<Rejtveny.Children.Count; i++)
            {
                if (Rejtveny.Children[i] is TextBox)
                {
                    Rejtveny.Children.Remove(Rejtveny.Children[i] as TextBox);
                }
                else
                {
                    i++;
                }
            }

			int sorokSzama = (int)cb_sorokszama.SelectedItem;
            int oszlopokSzama = (int)cb_oszlopokszama.SelectedItem;


				for (int r = 0; r<sorokSzama; r++)
            {
                for(int c = 0; c<oszlopokSzama; c++)
                {
                    TextBox aktualistb = new TextBox();

                    aktualistb.Width = 15;
                    aktualistb.Height = 15;
                    aktualistb.TextAlignment = TextAlignment.Center;
                    aktualistb.VerticalContentAlignment = VerticalAlignment.Center;
                    aktualistb.MaxLength = 1;

                    Canvas.SetLeft(aktualistb, c * 20);
                    Canvas.SetTop(aktualistb, r * 20);

                    Rejtveny.Children.Add(aktualistb);


				}
            }
		}
	}
}