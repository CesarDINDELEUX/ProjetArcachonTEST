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
using System.Configuration;



namespace ModernUINavigationApp1.Pages
{
    /// <summary>
    /// Interaction logic for AjoutEpreuve.xaml
    /// </summary>
    public partial class AjoutEpreuve : UserControl
    {
        public AjoutEpreuve()
        {
            InitializeComponent();
            ComboBoxChoixCourse.ItemsSource = LibArcachon.CourseDAO.List();           
        }

        private void ButtonValider_Click(object sender, RoutedEventArgs e)
        {
            LibArcachon.Course lacourse = ComboBoxChoixCourse.SelectedItem as LibArcachon.Course;
            LibArcachon.Epreuve lol = new LibArcachon.Epreuve {Point_Arrive= TexdBoxPointDepart.Text, Point_Depart = TexdBoxPointDepart.Text, Heure_Arrive_theorique = DateTime.Parse(TextBoxHeureArriveTheo.Text), Heure_Depart = DateTime.Parse(TextBoxHeureDepart.Text), Course = lacourse, idcourse = 1};
            //LibArcachon.EpreuveDAO.AjoutEpreuve(TexdBoxPointDepart.Text, TextBoxPointArrive.Text, DateTime.Parse(TextBoxHeureDepart.Text), DateTime.Parse(TextBoxHeureArriveTheo.Text), ComboBoxChoixCourse.SelectedItem as LibArcachon.Course);
            LibArcachon.EpreuveDAO.AjouterEpreuve(lol);

            //LibArcachon.Course lol = new LibArcachon.Course { Nom = TexdBoxPointDepart.Text, Lieu = TextBoxPointArrive.Text };
            //LibArcachon.CourseDAO.Add(lol);
        }
    }
}
