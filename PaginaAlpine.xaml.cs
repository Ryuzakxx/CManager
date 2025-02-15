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
    /// Logica di interazione per PaginaAlpine.xaml
    /// </summary>
    public partial class PaginaAlpine : Page
    {
        public PaginaAlpine()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            lblGasly.Content = DatiGlobali.PuntiGasly.ToString();
            lblOcon.Content = DatiGlobali.PuntiOcon.ToString();

            int totalAlpine = DatiGlobali.PuntiGasly + DatiGlobali.PuntiOcon;
            lblTotAlpine.Content = totalAlpine.ToString();

        }
    }
}
