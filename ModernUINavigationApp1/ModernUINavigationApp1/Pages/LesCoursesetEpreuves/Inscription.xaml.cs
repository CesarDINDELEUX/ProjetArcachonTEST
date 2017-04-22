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
    /// Interaction logic for Inscription.xaml
    /// </summary>
    public partial class Inscription : UserControl
    {
        public Inscription()
        {
            InitializeComponent();
            ComboBoxListeCourse.ItemsSource = LibArcachon.CourseDAO.List();
            ComboBoxListeBateau.ItemsSource = LibArcachon.VoilierDAO.ListAll();
        }


        #region TextBox vider au GotFocus


        private void TextBoxNomBarreur_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxNomBarreur.Text = "";
        }

        private void TextBoxPrenomBarreur_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxPrenomBarreur.Text = "";
        }

        private void TextBoxLicenceBarreur_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxLicenceBarreur.Text = "";
        }

        private void TextBoxClubBarreur_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxClubBarreur.Text = "";
        }

        private void TextBoxSexeBarreur_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxSexeBarreur.Text = "";
        }

        private void TextBoxNeeBarreur_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxNeeBarreur.Text = "";
        }

        private void TextBoxNomEquipier1_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxNomEquipier1.Text = "";
        }

        private void TextBoxPrenomEquipier1_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxPrenomEquipier1.Text = "";
        }

        private void TextBoxLicenceEquipier1_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxLicenceEquipier1.Text = "";
        }

        private void TextBoxClubEquipier1_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxClubEquipier1.Text = "";
        }

        private void TextBoxSexeEquipier1_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxSexeEquipier1.Text = "";
        }

        private void TextBoxNeeEquipier1_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxNeeEquipier1.Text = "";
        }

        private void TextBoxNomEquipier2_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxNomEquipier2.Text = "";
        }

        private void TextBoxPrenomEquipier2_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxPrenomEquipier2.Text = "";
        }

        private void TextBoxLicenceEquipier2_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxLicenceEquipier2.Text = "";
        }

        private void TextBoxClubEquipier2_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxClubEquipier2.Text = "";
        }

        private void TextBoxSexeEquipier2_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxSexeEquipier2.Text = "";
        }

        private void TextBoxNeeEquipier2_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxNeeEquipier2.Text = "";
        }
        #endregion

        private void BoutonValiderInscription_Click(object sender, RoutedEventArgs e)
        {
            LibArcachon.ProjetArcachonEntities db = new LibArcachon.ProjetArcachonEntities();
            int numeroinscription = (db.Personne.Count() / 3) + 1;
            LibArcachon.Personne Barreur = new LibArcachon.Personne { Nom = TextBoxNomBarreur.Text, Prenom = TextBoxPrenomBarreur.Text, Date_naissance = DateTime.Parse(TextBoxNeeBarreur.Text), Numero_Licence = TextBoxLicenceBarreur.Text, Numero_Club = TextBoxClubBarreur.Text, Sexe = TextBoxSexeBarreur.Text, idNumeroInscription = numeroinscription.ToString() };
            LibArcachon.Personne equipier1 = new LibArcachon.Personne { Nom = TextBoxNomEquipier1.Text, Prenom = TextBoxPrenomEquipier1.Text, Date_naissance = DateTime.Parse(TextBoxNeeEquipier1.Text), Numero_Licence = TextBoxLicenceEquipier1.Text, Numero_Club = TextBoxClubEquipier1.Text, Sexe = TextBoxSexeEquipier1.Text, idNumeroInscription = numeroinscription.ToString() };
            LibArcachon.Personne equipier2 = new LibArcachon.Personne { Nom = TextBoxNomEquipier2.Text, Prenom = TextBoxPrenomEquipier2.Text, Date_naissance = DateTime.Parse(TextBoxNeeEquipier2.Text), Numero_Club = TextBoxClubEquipier2.Text, Numero_Licence = TextBoxLicenceEquipier2.Text, Sexe = TextBoxSexeEquipier2.Text, idNumeroInscription = numeroinscription.ToString() };
            LibArcachon.VoilierInscrit lol = new LibArcachon.VoilierInscrit { Personne = Barreur, Personne1 = equipier1, Personne2 = equipier2, idCourse = (ComboBoxListeCourse.SelectedItem as LibArcachon.Course).Id_Course, NumeroSerie = (ComboBoxListeBateau.SelectedItem as LibArcachon.Voilier).NumeroSerie };
            LibArcachon.PersonneDao.Add(Barreur, equipier1, equipier2, lol );
        }

        private void ComboBoxListeBateau_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LibArcachon.Voilier levoilier = ComboBoxListeBateau.SelectedItem as LibArcachon.Voilier;
            TextBoxClasseBateau.Text = levoilier.TypeDeClasse.Nom;

        }

    }
}
