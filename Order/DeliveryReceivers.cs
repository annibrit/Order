using Order.Archetype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class DeliveryReceivers : Archetypes<DeliveryReceiver>
    {
        public static DeliveryReceivers Instances
        { get; } = new DeliveryReceivers();
    }
}
