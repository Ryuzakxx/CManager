using System;
using System.Windows;
using System.Windows.Controls;

namespace F1RaceHub
{
    /// <summary>
    /// Logica di interazione per PaginaFerrari.xaml
    /// </summary>
    public partial class PaginaFerrari : Page
    {
        public PaginaFerrari()
        {
            InitializeComponent();

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
            lblLeclerc.Content = DatiGlobali.PuntiLeclerc.ToString();
            lblHamilton.Content = DatiGlobali.PuntiHamilton.ToString();
            int totalFerrari = DatiGlobali.PuntiLeclerc + DatiGlobali.PuntiHamilton;
            lblTotFerrari.Content = totalFerrari.ToString();

        }


    }
}
