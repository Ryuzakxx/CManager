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
    /// Logica di interazione per PaginaHaas.xaml
    /// </summary>
    public partial class PaginaHaas : Page
    {
        public PaginaHaas()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            lblHulkenberg.Content = DatiGlobali.PuntiHulkenberg.ToString();
            lblMagnussen.Content = DatiGlobali.PuntiMagnussen.ToString();

            int totalHaas = DatiGlobali.PuntiHulkenberg + DatiGlobali.PuntiMagnussen;
            lblTotHaas.Content = totalHaas.ToString();

        }
    }
}
