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
        }

        #region TextBox vider au GotFocus
        private void TextBoxDateFin_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxDateFin.Text = "";
        }

        private void TextBoxDateDebut_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBoxDateDebut.Text = "";
        }

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
    }
}
