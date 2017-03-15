﻿using Order.Archetype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class DeliveryReceivers : Archetypes<DeliveryReceiver>
    {
        public static DeliveryReceivers Instance
        { get; } = new DeliveryReceivers();

        public static void RemoveByOrderLineReceiver(DeliveryReceiver receiver)
        {
            var aa = Instance.ToList().Find(x => x.receiver == receiver);
            if (aa == null)
                return;
            Instance.Remove(aa);
        }
    }
}
