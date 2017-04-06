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

            ComboBoxChoixBateau.ItemsSource = LibArcachon.VoilierDAO.ListAll();

            

        }

        private void ButtonValider_Click(object sender, RoutedEventArgs e)
        {
            LibArcachon.Entreprise ajout = new LibArcachon.Entreprise { Nom = TextBoxNomEntreprise.Text, Adresse = TextBoxAdresse.Text, Num_Tel = int.Parse(TextBoxTelephone.Text), mail = TextBoxMail.Text, Contact = TextBoxContact.Text, };
            LibArcachon.EntrepriseDAO.Add(ajout);



            LibArcachon.Sponsoring ajoutS = new LibArcachon.Sponsoring { Montant = int.Parse(TextBoxMontant.Text) };
            LibArcachon.SponsoringDAO.Add(ajoutS);
        }
    }
}
