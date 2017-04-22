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
    /// Interaction logic for Entreprise.xaml
    /// </summary>
    public partial class Entreprise : UserControl
    {
        public Entreprise()
        {
            InitializeComponent();
            ListViewEntreprise.ItemsSource = LibArcachon.EntrepriseDAO.ListAll();
        }

        private void ButtonSupprimer_Click(object sender, RoutedEventArgs e)
        {
            var Button = sender as Button;
            int code = int.Parse(Button.Tag.ToString());
            LibArcachon.EntrepriseDAO.Delete(code);
            ListViewEntreprise.ItemsSource = LibArcachon.EntrepriseDAO.ListAll();
            
            
        }
        //private void ButtonModifier_Click(object sender, RoutedEventArgs e)
        //{
        //    var Button = sender as Button;
        //    int code = int.Parse(Button.Tag.ToString());
        //    NavigationCommands.GoToPage.Execute("/Pages/Entreprises/AjoutEntreprise.xaml#CustomerID=12345", this);


        //}
        private void load(object sender, RoutedEventArgs e)
        {
            ListViewEntreprise.ItemsSource = LibArcachon.EntrepriseDAO.ListAll();
        }
    }
}
