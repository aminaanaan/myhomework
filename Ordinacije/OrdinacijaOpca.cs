using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SvezaOrdinacije
{
    public class OrdinacijaOpca : Ordinacija
    {
        public OrdinacijaOpca(int iznosNaplate, int iDOrdinacije) : base(iznosNaplate)
        {
            iDOrdinacije = 3;
        }
    }
}
