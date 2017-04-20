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
    /// Logique d'interaction pour AjoutCourse.xaml
    /// </summary>
    public partial class AjoutCourse : UserControl
    {
        public AjoutCourse()
        {
            InitializeComponent();
        }

        private void ButtonValider_Click(object sender, RoutedEventArgs e)
        {
            LibArcachon.Course course = new LibArcachon.Course { Nom = textboxnomcourse.Text, Lieu = textboxlieu.Text };
            LibArcachon.CourseDAO.Add(course);

        }
    }
}
