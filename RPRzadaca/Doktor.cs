using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SvezaOrdinacije;
namespace RPRzadaca
{
    sealed partial class Doktor:Uposlenik
    {
        private double bonus;
        private string mojagarancija;
        private string Ime ;
        private string Prezime ;
        private string vrstaDoktora;
        private int BrojPregledanihPacijenata ;
        private int Plata ;
        public double Bonus { get => bonus; set => bonus = value; }
        public string Mojagarancija { get => mojagarancija; set => mojagarancija = value; }
        public string Ime1 { get => Ime; set => Ime = value; }
        public string Prezime1 { get => Prezime; set => Prezime = value; }
        public int BrojPregledanihPacijenata1 { get => BrojPregledanihPacijenata; set => BrojPregledanihPacijenata = value; }
        public int Plata1 { get => Plata; set => Plata = value; }
        public string VrstaDoktora { get => vrstaDoktora; set => vrstaDoktora = value; }
        public Ordinacija ordinacijaDoktora = new Ordinacija(50);
      //  for(int i=0;i<>)
    }
}
