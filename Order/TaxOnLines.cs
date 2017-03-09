using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.Archetype;

namespace Order
{
    public class TaxOnLines : Archetypes<TaxOnLine>
    {
        public static TaxOnLines Instances
        { get; } = new TaxOnLines();
    }
}
