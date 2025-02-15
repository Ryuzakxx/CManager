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
    /// Logica di interazione per PaginaVCARB.xaml
    /// </summary>
    public partial class PaginaVCARB : Page
    {
        public PaginaVCARB()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            lblTsunoda.Content = DatiGlobali.PuntiTsunoda.ToString();
            lblHadjar.Content = DatiGlobali.PuntiHadjar.ToString();

            int totalVCARB = DatiGlobali.PuntiTsunoda + DatiGlobali.PuntiHadjar;
            lblTotVCARB.Content = totalVCARB.ToString();

        }
    }
}
