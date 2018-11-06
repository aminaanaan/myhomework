using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RPRzadaca
{
    public class NormalniPacijent
    {
        private string ime;
        private string prezime;
        private DateTime datumrodjenja;
        private string maticniBroj;
        private string spol;
        private string adresaStanovanja;

        private string GetAdresaStanovanja()
        {
            return AdresaStanovanja;
        }

        private void SetAdresaStanovanja(string value)
        {
            AdresaStanovanja = value;
        }

        public string Spol { get => spol; set => spol = value; }
        public string MaticniBroj { get => maticniBroj; set => maticniBroj = value; }
        public DateTime Datumrodjenja { get => datumrodjenja; set => datumrodjenja = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Ime { get => ime; set => ime = value; }
        public DateTime DatumPrijema { get => datumPrijema; set => datumPrijema = value; }
        public string BracnoStanje { get => bracnoStanje; set => bracnoStanje = value; }
        public string Zdravstvenaknjizica { get => zdravstvenaknjizica; set => zdravstvenaknjizica = value; }
        public string AdresaStanovanja { get => adresaStanovanja; set => adresaStanovanja = value; }
        public int BrojPosjetaKlinici { get => brojPosjetaKlinici; set => brojPosjetaKlinici = value; }
        public List<string> postupci = new List<string>();
        public List<double> cijenePregleda = new List<double>();
        public Karton kartonPacijenta;
        private int brojPosjetaKlinici = 0;
        private string bracnoStanje;
        private DateTime datumPrijema;
        private string zdravstvenaknjizica;
        public NormalniPacijent(string ime,string prezime,DateTime datumrodjenja,string spol,string adresastanovanja,string bracnostanje,DateTime datumprijema,string zdravstvena)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Datumrodjenja = datumrodjenja;
            this.Spol = spol;
            this.SetAdresaStanovanja(adresastanovanja);
            this.bracnoStanje = bracnostanje;
            this.DatumPrijema = datumprijema;
            this.Zdravstvenaknjizica = zdravstvena;
        }
         public NormalniPacijent()
        {

        }
            }

}
