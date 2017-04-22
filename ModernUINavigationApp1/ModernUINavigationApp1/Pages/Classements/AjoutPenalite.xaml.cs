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

namespace ModernUINavigationApp1.Pages.Classements
{
    /// <summary>
    /// Logique d'interaction pour AjoutPenalite.xaml
    /// </summary>
    public partial class AjoutPenalite : UserControl
    {
        public AjoutPenalite()
        {
            InitializeComponent();
            ComboCourse.ItemsSource = LibArcachon.CourseDAO.List();
            ComboPenalite.ItemsSource = LibArcachon.ListePenaliteDAO.ListAll();
        }

        private void ButtonValider_Click(object sender, RoutedEventArgs e)
        {
            LibArcachon.Penalite = new LibArcachon.Penalite {ListePenalite = (ComboPenalite.SelectedItem as LibArcachon.ListePenalite), Latitude = textBox.Text, Logitude = textBox1.Text, VoilierInscrit1 = ComboBateau.SelectedItem as LibArcachon.VoilierInscrit, Duree = }
        }
        
        private void ComboCourse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBateau.ItemsSource = LibArcachon.CourseDAO.GetVoiliersInscrit((ComboCourse.SelectedItem as LibArcachon.Course).Id_Course);
        }
    }
}
