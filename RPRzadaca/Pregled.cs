using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RPRzadaca
{
     class Pregled
    {
        public Pregled()
        {

        }
        public Pregled(string tipPregleda, DateTime datumPregleda, string rezultatiPregleda, string terapija, bool dugorocnaTerapija, Doktor odgovorniDoktor)
        {
            TipPregleda1 = tipPregleda;
            DatumPregleda1 = datumPregleda;
            RezultatiPregleda1 = rezultatiPregleda;
            this.Terapija = terapija;
            this.DugorocnaTerapija = dugorocnaTerapija;
            this.OdgovorniDoktor1 = odgovorniDoktor;
        }

        public Pregled(Doktor odgovorniDoktor, NormalniPacijent pacijentKojiSePregleda)
        {
            OdgovorniDoktor = odgovorniDoktor;
            this.pacijentKojiSePregleda = pacijentKojiSePregleda;
        }

        private string TipPregleda;
        private DateTime DatumPregleda;
        private string RezultatiPregleda;
        private string terapija;
        private bool dugorocnaTerapija=false;
        private Doktor OdgovorniDoktor;
        private NormalniPacijent pacijentKojiSePregleda;

        public string TipPregleda1 { get => TipPregleda; set => TipPregleda = value; }
        public DateTime DatumPregleda1 { get => DatumPregleda; set => DatumPregleda = value; }
        public string RezultatiPregleda1 { get => RezultatiPregleda; set => RezultatiPregleda = value; }
        public string Terapija { get => terapija; set => terapija = value; }
        public bool DugorocnaTerapija { get => dugorocnaTerapija; set => dugorocnaTerapija = value; }
       public Doktor OdgovorniDoktor1 { get => OdgovorniDoktor; set => OdgovorniDoktor = value; }
        public NormalniPacijent PacijentKojiSePregleda { get => pacijentKojiSePregleda; set => pacijentKojiSePregleda = value; }
    }
}
