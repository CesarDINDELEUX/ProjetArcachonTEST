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

namespace ModernUINavigationApp1.Pages.LesCoursesetEpreuves
{
    /// <summary>
    /// Interaction logic for ClassementCourse.xaml
    /// </summary>
    public partial class ClassementCourse : UserControl
    {
        public ClassementCourse()
        {
            InitializeComponent();
            List<LibArcachon.Course> Coursess = new List<LibArcachon.Course>();
            Coursess = LibArcachon.CourseDAO.List();
            ComboBoxCourse.ItemsSource = Coursess;
        }

        private void ComboBoxCourse_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<LibArcachon.VoilierInscrit> lol;
            lol = LibArcachon.CourseDAO.GetVoiliersInscrit((ComboBoxCourse.SelectedItem as LibArcachon.Course).Id_Course);
            ListViewClassement.ItemsSource = lol;
            
        }
    }
}
