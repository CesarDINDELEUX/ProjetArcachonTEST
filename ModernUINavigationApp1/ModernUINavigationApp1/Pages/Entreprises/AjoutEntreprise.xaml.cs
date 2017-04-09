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
    /// Interaction logic for AjoutEntreprise.xaml
    /// </summary>
    public partial class AjoutEntreprise : UserControl
    {
        public AjoutEntreprise()
        {
            InitializeComponent();
                ButtonValider.IsEnabled = false;
        }

        private void EnableButton()
        {
            if (TextBoxAdresse.Text == "" || TextBoxContact.Text == "" || TextBoxMail.Text == "" || TextBoxNomEntreprise.Text == "" || TextBoxTelephone.Text == "")
            {
                ButtonValider.IsEnabled = false;
            }
            else
            {
                ButtonValider.IsEnabled = true;
            }
        }

        private void ButtonValider_Click(object sender, RoutedEventArgs e)
        {       
            LibArcachon.Entreprise entreprise = new LibArcachon.Entreprise { Nom = TextBoxNomEntreprise.Text, Adresse = TextBoxAdresse.Text, Num_Tel = int.Parse(TextBoxTelephone.Text), mail = TextBoxMail.Text, Contact = TextBoxContact.Text, };
            LibArcachon.EntrepriseDAO.Add(entreprise);
        }

        private void TextBoxContact_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableButton();
        }

        private void TextBoxMail_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableButton();
        }

        private void TextBoxTelephone_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableButton();
        }

        private void TextBoxAdresse_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableButton();
        }

        private void TextBoxNomEntreprise_TextChanged(object sender, TextChangedEventArgs e)
        {
            EnableButton();
        }
    }
}
