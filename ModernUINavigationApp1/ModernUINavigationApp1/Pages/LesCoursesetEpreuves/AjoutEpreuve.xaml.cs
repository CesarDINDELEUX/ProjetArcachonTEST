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
    /// Interaction logic for AjoutEpreuve.xaml
    /// </summary>
    public partial class AjoutEpreuve : UserControl
    {
        public AjoutEpreuve()
        {
            InitializeComponent();
            ComboBoxChoixCourse.ItemsSource = LibArcachon.CourseDAO.List();
            ButtonValider.IsEnabled = false;
        }

        private void enableButton()
        {
            if (TexdBoxPointDepart.Text == "" || TextBoxHeureArriveTheo.Value == null || TextBoxPointArrive.Text == "" || ComboBoxChoixCourse.SelectedItem == null || TextBoxHeureDepart.Value == null)
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

            LibArcachon.Course lacourse = ComboBoxChoixCourse.SelectedItem as LibArcachon.Course;
            int id_course = lacourse.Id_Course;
            LibArcachon.Epreuve lol = new LibArcachon.Epreuve { Point_Arrive = TexdBoxPointDepart.Text, Point_Depart = TexdBoxPointDepart.Text, Heure_Depart = DateTime.Parse(TextBoxHeureDepart.Value.ToString()), Heure_Arrive_theorique = DateTime.Parse(TextBoxHeureArriveTheo.Value.ToString()), idcourse = id_course };
            LibArcachon.EpreuveDAO.Add(lol);
        }

        private void TexdBoxPointDepart_TextChanged(object sender, TextChangedEventArgs e)
        {
            enableButton();
        }

        private void TextBoxPointArrive_TextChanged(object sender, TextChangedEventArgs e)
        {
            enableButton();
        }

        private void TextBoxHeureDepart_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            enableButton();
        }

        private void TextBoxHeureArriveTheo_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            enableButton();
        }

        private void ComboBoxChoixCourse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            enableButton();
        }
    }
}
