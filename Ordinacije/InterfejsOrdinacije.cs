using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvezaOrdinacije
{
    interface INterfejsOrdinacije
    {
        int IznosNaplate();
        int IDOrdinacije { get; set; }
    }
}
