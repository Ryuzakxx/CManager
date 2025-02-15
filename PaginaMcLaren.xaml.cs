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
    /// Logica di interazione per PaginaMcLaren.xaml
    /// </summary>
    public partial class PaginaMcLaren : Page
    {
        public PaginaMcLaren()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            lblNorris.Content = DatiGlobali.PuntiNorris.ToString();
            lblPiastri.Content = DatiGlobali.PuntiPiastri.ToString();

            int totalMcLaren = DatiGlobali.PuntiNorris + DatiGlobali.PuntiPiastri;
            lblTotMcLaren.Content = totalMcLaren.ToString();

        }
    }
}
