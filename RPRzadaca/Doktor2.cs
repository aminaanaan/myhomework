using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SvezaOrdinacije;
namespace RPRzadaca
{
    sealed partial class Doktor
    {
        public Doktor()
        {
            Ime1 = "Neko";
            Prezime1 = "Nekic";
            Mojagarancija = "Ne garantuje";
        }
        public Doktor(string ime, string prezime, string vrstaDoktora, string mojagarancija, Ordinacija ordinacijaDoktora)
        {
            this.Ime1 = ime;
            this.Prezime1 = prezime;
            this.vrstaDoktora = vrstaDoktora;
            this.mojagarancija = mojagarancija;
            this.ordinacijaDoktora = ordinacijaDoktora;
        }
        void ObracunPlate(int brojPacijenata)
        {
            if (brojPacijenata > 20) this.Plata1 = 1500 + 20 * 30; //neke vrijednosti
            else this.Plata1 = 1500 + brojPacijenata * 30;
        }
    }
}
