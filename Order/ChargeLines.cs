using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.Archetype;

namespace Order
{
    public class ChargeLines : Archetypes<ChargeLine>
    {
        public static ChargeLines Instances
        { get; } = new ChargeLines();
    }
}
