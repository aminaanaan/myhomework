using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPRzadaca
{
    public class Hitnislucaj:NormalniPacijent
    {
        private bool prvaPomoc=false;
        private bool stabilan=false;
        private string postupakLijecenja;
        private string vrijemeSmrti;
        private string uzrokSmrti;

        private string GetUzrokSmrti()
        {
            return UzrokSmrti;
        }

        private void SetUzrokSmrti(string value)
        {
            UzrokSmrti = value;
        }

        private string obdukcija = "Nije potrebno";

        public Hitnislucaj(string ime, string prezime, DateTime datumrodjenja, string spol, string adresastanovanja, string bracnostanje, DateTime datumprijema, string zdravstvena, bool prvapomoc,
        bool stabilan):base(ime,prezime,datumrodjenja,spol,adresastanovanja, bracnostanje, datumprijema, zdravstvena)
        {
            this.Prvapomoc = prvapomoc;
            this.Stabilan = stabilan;
        }
        public Hitnislucaj(NormalniPacijent n)
        {
        }
        public bool Stabilan { get => stabilan; set => stabilan = value; }
        public bool Prvapomoc { get => prvaPomoc; set => prvaPomoc = value; }
        public string UzrokSmrti { get => uzrokSmrti; set => uzrokSmrti = value; }
        public string PostupakLijecenja { get => postupakLijecenja; set => postupakLijecenja = value; }
        public string Obdukcija { get => obdukcija; set => obdukcija = value; }
        public string VrijemeSmrti { get => vrijemeSmrti; set => vrijemeSmrti = value; }
    }
}
