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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModernUINavigationApp1.Pages
{
    /// <summary>
    /// Interaction logic for AjoutVoilier.xaml
    /// </summary>
    public partial class AjoutVoilier : UserControl
    {
        public AjoutVoilier()
        {
            InitializeComponent();
            ComboBoxChoixDeVoilier.ItemsSource = LibArcachon.TypeDeClasseDAO.ListAll();
            ButtonValider.IsEnabled = false;
            
              
        }

        private void ButtonValider_Click(object sender, RoutedEventArgs e)
        {
            LibArcachon.TypeDeClasse LaClasse = ComboBoxChoixDeVoilier.SelectedItem as LibArcachon.TypeDeClasse;
            int id_classe = LaClasse.Id_Classe;
            LibArcachon.Voilier NewVoilier = new LibArcachon.Voilier {NumeroSerie = TextBoxSerie.Text, Nom = TextBoxNomVoilier.Text, IdClasse = id_classe  };
            LibArcachon.VoilierDAO.Add(NewVoilier);
        }

        private void enable_button()
        {
            if (TextBoxNomVoilier.Text == "" || TextBoxSerie.Text == "" || ComboBoxChoixDeVoilier.SelectedItem == null)
            {
                ButtonValider.IsEnabled = false;
            }
            else
            {
                ButtonValider.IsEnabled = true;
            }
        }
        private void TextBoxSerie_TextChanged(object sender, TextChangedEventArgs e)
        {
            enable_button();
        }

        private void TextBoxNomVoilier_TextChanged(object sender, TextChangedEventArgs e)
        {
            enable_button();
        }

        private void ComboBoxChoixDeVoilier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            enable_button();
        }
    }
}
