using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvezaOrdinacije
{
    public class Ordinacija:INterfejsOrdinacije
    {

        int iznosNaplate=50;
public Ordinacija(int iznosNaplate, int iDOrdinacije)
        {
            this.iznosNaplate = iznosNaplate;
            IDOrdinacije = iDOrdinacije;
        }

        public Ordinacija(int iznosNaplate)
        {
            this.iznosNaplate = iznosNaplate;
        }

        private int iDOrdinacije=2;

        public int IDOrdinacije { get => iDOrdinacije; set => iDOrdinacije = value; }

        virtual public int IznosNaplate()
        {
            return 50 * IDOrdinacije;
        }
    }
}
