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
    /// Interaction logic for Epreuve.xaml
    /// </summary>
    public partial class Epreuve : UserControl
    {
       public Epreuve()
        {
            InitializeComponent();
            List<LibArcachon.Course> Coursess = new List<LibArcachon.Course>();
            Coursess = LibArcachon.CourseDAO.List();
            ComboBoxCourse.ItemsSource = Coursess;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window ajoutepreuve = new Window();
            ajoutepreuve.Content = new AjoutEpreuve();
            ajoutepreuve.Show();
        }

        private void ComboBoxCourse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            LibArcachon.Course lol = ComboBoxCourse.SelectedItem as LibArcachon.Course; 
            List<LibArcachon.Epreuve> ListEp = LibArcachon.EpreuveDAO.getEpreuvesByCourse(lol.Id_Course);
        }
    }
}
