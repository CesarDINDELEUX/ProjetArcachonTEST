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

namespace ModernUINavigationApp1.Pages.Classement
{
    /// <summary>
    /// Interaction logic for ClassementEpreuve.xaml
    /// </summary>
    public partial class ClassementEpreuve : UserControl
    {
        public ClassementEpreuve()
        {
            InitializeComponent();
            ComboBoxCourse.ItemsSource = LibArcachon.CourseDAO.List();
        }

        private void ComboBoxCourse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxEpreuve.ItemsSource = null;
            LibArcachon.Course lacourse = ComboBoxCourse.SelectedItem as LibArcachon.Course;
            int id_course = lacourse.Id_Course;
            ComboBoxEpreuve.ItemsSource = LibArcachon.EpreuveDAO.getEpreuvesByCourse(id_course);
        }

        private void ButtonPenalite_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
