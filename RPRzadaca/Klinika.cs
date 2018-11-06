using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SvezaOrdinacije;
namespace RPRzadaca
{
    class Klinika //kontejner
    {
        public List<Doktor> doktori=new List<Doktor>();
        public List<NormalniPacijent> pacijenti=new List<NormalniPacijent>();
        public List<Pregled> pregledi = new List<Pregled>();
        public List<Karton> kartoniPacijenata = new List<Karton>();
        public List<Pregled> redoslijedOftalmolog = new List<Pregled>();
        public List<Pregled> redoslijedOpcaPraksa = new List<Pregled>();
        public List<Pregled> redoslijedPsiholog= new List<Pregled>();
        public Doktor oftalmolog = new Doktor("Gospodin", "Mrkva", "oftalmolog", "GARANCIJA1", new OrdinacijaOftalmologa(50, 1));
        public Doktor psiholog = new Doktor("Gospodin", "Zivac", "psiholog", "GARANCIJA2", new OrdinacijaPsihologa(150, 3));
        public Doktor opcaPraksa = new Doktor("Gospodin", "Opci", "opca praksa", "GARANCIJA3", new OrdinacijaOpca(200, 4));
        public Klinika()
        {

        }

    }
}
