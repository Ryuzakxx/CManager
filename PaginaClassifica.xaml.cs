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
    /// Logica di interazione per PaginaClassifica.xaml
    /// </summary>
    public partial class PaginaClassifica : Page
    {
        public PaginaClassifica()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            

            var punteggi = new List<(string Nome, int Punti)>
    {
        ("Leclerc",      DatiGlobali.PuntiLeclerc),
        ("Hamilton",     DatiGlobali.PuntiHamilton),
        ("Norris",       DatiGlobali.PuntiNorris),
        ("Piastri",      DatiGlobali.PuntiPiastri),
        ("Verstappen",   DatiGlobali.PuntiVerstappen),
        ("Lawson",       DatiGlobali.PuntiLawson),
        ("Antonelli",    DatiGlobali.PuntiAntonelli),
        ("Russell",      DatiGlobali.PuntiRussell),
        ("Gasly",        DatiGlobali.PuntiGasly),
        ("Ocon",         DatiGlobali.PuntiOcon),
        ("Tsunoda",      DatiGlobali.PuntiTsunoda),
        ("Hadjar",       DatiGlobali.PuntiHadjar),
        ("Bottas",       DatiGlobali.PuntiBottas),
        ("Zhou",         DatiGlobali.PuntiZhou),
        ("Hulkenberg",   DatiGlobali.PuntiHulkenberg),
        ("Magnussen",    DatiGlobali.PuntiMagnussen),
        ("Albon",        DatiGlobali.PuntiAlbon),
        ("Colapinto",    DatiGlobali.PuntiColapinto),
        ("Alonso",       DatiGlobali.PuntiAlonso),
        ("Stroll",       DatiGlobali.PuntiStroll)
    };

            var classificaOrdinata = punteggi
                .OrderByDescending(x => x.Punti)
                .ToList();

            // Costruisci la stringa con i dati in ordine
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < classificaOrdinata.Count; i++)
            {
                int posizione = i + 1;
                string nomePilota = classificaOrdinata[i].Nome;
                int puntiPilota = classificaOrdinata[i].Punti;

                sb.AppendLine($"{posizione}. {nomePilota} - {puntiPilota}");
            }

            // Assegna al Label (usando `Content`):
            lblClassifica.Content = sb.ToString();
        }

    }
}
