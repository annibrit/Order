using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.Archetype;

namespace Order
{
    public class OrderLines : Archetypes<OrderLine>
    {
        public static OrderLines Instances
        { get; } = new OrderLines();
    }
}
