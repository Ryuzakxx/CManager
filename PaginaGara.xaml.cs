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
    /// Logica di interazione per PaginaGara.xaml
    /// </summary>
    public partial class PaginaGara : Page
    {
        public PaginaGara()
        {
            InitializeComponent();
        }

        private void Click_Genera(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            // Leclerc
            int punteggioLeclerc = 0;
            
               punteggioLeclerc += rnd.Next(1, 27);
            
            DatiGlobali.PuntiLeclerc = punteggioLeclerc;

            // Hamilton
            int punteggioHamilton = 0;
            
            
            punteggioHamilton += rnd.Next(1, 27);
            
            DatiGlobali.PuntiHamilton = punteggioHamilton;

            // Norris
            int punteggioNorris = 0;
            
                punteggioNorris += rnd.Next(1, 27);
            
            DatiGlobali.PuntiNorris = punteggioNorris;

            // Piastri
            int punteggioPiastri = 0;
            
               punteggioPiastri += rnd.Next(1, 27);
            
            DatiGlobali.PuntiPiastri = punteggioPiastri;

            // Verstappen
            int punteggioVerstappen = 0;
            
                punteggioVerstappen += rnd.Next(1, 27);
            
            DatiGlobali.PuntiVerstappen = punteggioVerstappen;

            // Lawson
            int punteggioLawson = 0;
            
                punteggioLawson += rnd.Next(1, 27);
            
            DatiGlobali.PuntiLawson = punteggioLawson;

            // Antonelli
            int punteggioAntonelli = 0;
            
                punteggioAntonelli += rnd.Next(1, 27);
            
            DatiGlobali.PuntiAntonelli = punteggioAntonelli;

            // Russell
            int punteggioRussell = 0;
            
                punteggioRussell += rnd.Next(1, 27);
            
            DatiGlobali.PuntiRussell = punteggioRussell;

            // Gasly
            int punteggioGasly = 0;
            
                punteggioGasly += rnd.Next(1, 27);
            
            DatiGlobali.PuntiGasly = punteggioGasly;

            // Ocon
            int punteggioOcon = 0;
            
                punteggioOcon += rnd.Next(1, 27);
           
            DatiGlobali.PuntiOcon = punteggioOcon;

            // Tsunoda
            int punteggioTsunoda = 0;
            
                punteggioTsunoda += rnd.Next(1, 27);
            
            DatiGlobali.PuntiTsunoda = punteggioTsunoda;

            // Hadjar
            int punteggioHadjar = 0;
            
                punteggioHadjar += rnd.Next(1, 27);
            
            DatiGlobali.PuntiHadjar = punteggioHadjar;

            // Bottas
            int punteggioBottas = 0;
            
                punteggioBottas += rnd.Next(1, 27);
           
            DatiGlobali.PuntiBottas = punteggioBottas;

            // Zhou
            int punteggioZhou = 0;
            
                punteggioZhou += rnd.Next(1, 27);
            
            DatiGlobali.PuntiZhou = punteggioZhou;

            // Hulkenberg
            int punteggioHulkenberg = 0;
            
                punteggioHulkenberg += rnd.Next(1, 27);
            
            DatiGlobali.PuntiHulkenberg = punteggioHulkenberg;

            // Magnussen
            int punteggioMagnussen = 0;
            
                punteggioMagnussen += rnd.Next(1, 27);
            
            DatiGlobali.PuntiMagnussen = punteggioMagnussen;

            // Albon
            int punteggioAlbon = 0;
            
                punteggioAlbon += rnd.Next(1, 27);
            
            DatiGlobali.PuntiAlbon = punteggioAlbon;

            // Colapinto
            int punteggioColapinto = 0;
            
                punteggioColapinto += rnd.Next(1, 27);
            
            DatiGlobali.PuntiColapinto = punteggioColapinto;

            // Alonso
            int punteggioAlonso = 0;
            
                punteggioAlonso += rnd.Next(1, 27);
            
            DatiGlobali.PuntiAlonso = punteggioAlonso;

            // Stroll
            int punteggioStroll = 0;
            
                punteggioStroll += rnd.Next(1, 27);
            
            DatiGlobali.PuntiStroll = punteggioStroll;

            MessageBox.Show("La gara è terminata, clicca su 'Classifica' per scoprire i risultati!");
        }
    }
}
