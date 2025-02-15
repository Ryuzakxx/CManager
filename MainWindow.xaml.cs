using System.Windows;
using System.Windows.Controls;

namespace F1RaceHub
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickMain(object sender, RoutedEventArgs e)
        {
            Home.Navigate(new MainWindow()); 
        }

        private void ClickFerrari(object sender, RoutedEventArgs e)
        {
            Home.Navigate(new PaginaFerrari());
        }

        private void ClickMcLaren(object sender, RoutedEventArgs e)
        {
            Home.Navigate(new PaginaMcLaren());
        }

        private void ClickRedBull(object sender, RoutedEventArgs e)
        {
            Home.Navigate(new PaginaRedBull());
        }

        private void ClickMercedes(object sender, RoutedEventArgs e)
        {
            Home.Navigate(new PaginaMercedes());
        }

        private void ClickAstonMartin(object sender, RoutedEventArgs e)
        {
            Home.Navigate(new PaginaAstonMartin());
        }

        private void ClickAlpine(object sender, RoutedEventArgs e)
        {
            Home.Navigate(new PaginaAlpine());
        }

        private void ClickVCARB(object sender, RoutedEventArgs e)
        {
            Home.Navigate(new PaginaVCARB());
        }

        private void ClickHaas(object sender, RoutedEventArgs e)
        {
            Home.Navigate(new PaginaHaas());
        }

        private void ClickKick(object sender, RoutedEventArgs e)
        {
            Home.Navigate(new PaginaKick());
        }

        private void ClickWilliams(object sender, RoutedEventArgs e)
        {
            Home.Navigate(new PaginaWilliams());
        }

        private void ClickPunteggio(object sender, RoutedEventArgs e)
        {
            Home.Navigate(new PaginaGara());
        }

        private void ClickClassifica(object sender, RoutedEventArgs e)
        {
            Home.Navigate(new PaginaClassifica());
        }
    }
}
