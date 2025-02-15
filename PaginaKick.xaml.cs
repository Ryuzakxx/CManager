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
    /// Logica di interazione per PaginaKick.xaml
    /// </summary>
    public partial class PaginaKick : Page
    {
        public PaginaKick()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            lblBottas.Content = DatiGlobali.PuntiBottas.ToString();
            lblZhou.Content = DatiGlobali.PuntiZhou.ToString();

            int totalKick = DatiGlobali.PuntiBottas + DatiGlobali.PuntiZhou;
            lblTotKick.Content = totalKick.ToString();

        }
    }
}
