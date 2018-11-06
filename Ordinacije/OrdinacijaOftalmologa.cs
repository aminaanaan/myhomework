using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SvezaOrdinacije
{
    public class OrdinacijaOftalmologa:Ordinacija
    {
        int iDordinacije = 1;



        public int IDordinacije1 { get => iDordinacije; set => iDordinacije = value; }


        public OrdinacijaOftalmologa(int iznosNaplate, int iDOrdinacije) : base(iznosNaplate)
        {
            iDOrdinacije = 1;
        }
    }
}
