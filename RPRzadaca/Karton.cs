using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RPRzadaca
{
    public class Karton
    {
        private DateTime datumOtvaranjaKartona;
        private string vakcinacija;
        private string bolesti;
        private NormalniPacijent pacijent17818;
        private bool pacijentPusac;
        private bool pacijentAlkohol;
        private bool pacijentDroga;
        private List<Pregled> preglediPacijenta=new List<Pregled>();

        public Karton(NormalniPacijent pacijent17818)
        {
            this.pacijent17818 = pacijent17818;
        }

        public Karton(DateTime datumOtvaranjaKartona, string vakcinacija, string bolesti, NormalniPacijent pacijent17818)
        {
            this.datumOtvaranjaKartona = datumOtvaranjaKartona;
            this.vakcinacija = vakcinacija;
            this.bolesti = bolesti;
            this.pacijent17818 = pacijent17818;
        }

        public DateTime DatumOtvaranjaKartona { get => datumOtvaranjaKartona; set => datumOtvaranjaKartona = value; }
        public string Vakcinacija { get => vakcinacija; set => vakcinacija = value; }
        public string Bolesti { get => bolesti; set => bolesti = value; }
        public NormalniPacijent Pacijent17818 { get => pacijent17818; set => pacijent17818 = value; }
        public bool PacijentPusac { get => pacijentPusac; set => pacijentPusac = value; }
        public bool PacijentAlkohol { get => pacijentAlkohol; set => pacijentAlkohol = value; }
        public bool PacijentDroga { get => pacijentDroga; set => pacijentDroga = value; }
        internal List<Pregled> PreglediPacijenta { get => preglediPacijenta; set => preglediPacijenta = value; }
    }
}