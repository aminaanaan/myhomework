using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RPRzadaca
{
   abstract class Uposlenik
    {
        private string Ime { get; set; }
        private string Prezime { get; set; }
        private DateTime Datumrodjenja { get; set; }
        private string Maticnibroj { get; set; }
        private string Spol { get; set; }
    }
}
