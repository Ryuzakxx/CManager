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
    /// Logica di interazione per PaginaWilliams.xaml
    /// </summary>
    public partial class PaginaWilliams : Page
    {
        public PaginaWilliams()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            lblAlbon.Content = DatiGlobali.PuntiAlbon.ToString();
            lblColapinto.Content = DatiGlobali.PuntiColapinto.ToString();

            int totalWilliams = DatiGlobali.PuntiAlbon + DatiGlobali.PuntiColapinto;
            lblTotWilliams.Content = totalWilliams.ToString();

        }
    }
}
