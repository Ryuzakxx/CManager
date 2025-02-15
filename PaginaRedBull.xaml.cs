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
    /// Logica di interazione per PaginaRedBull.xaml
    /// </summary>
    public partial class PaginaRedBull : Page
    {
        public PaginaRedBull()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            lblVerstappen.Content = DatiGlobali.PuntiVerstappen.ToString();
            lblLawson.Content = DatiGlobali.PuntiLawson.ToString();

            int totalRedBull = DatiGlobali.PuntiVerstappen + DatiGlobali.PuntiLawson;
            lblTotRedBull.Content = totalRedBull.ToString();

        }
    }
}
