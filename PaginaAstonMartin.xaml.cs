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

namespace F1RaceHub
{
    /// <summary>
    /// Logica di interazione per PaginaAstonMartin.xaml
    /// </summary>
    public partial class PaginaAstonMartin : Page
    {
        public PaginaAstonMartin()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            lblAlonso.Content = DatiGlobali.PuntiAlonso.ToString();
            lblStroll.Content = DatiGlobali.PuntiStroll.ToString();

            int totalAston = DatiGlobali.PuntiAlonso + DatiGlobali.PuntiStroll;
            lblTotAston.Content = totalAston.ToString();

        }
    }
}
