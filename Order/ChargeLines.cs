﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.Archetype;

namespace Order
{
    public class ChargeLines : Archetypes<ChargeLine>
    {
        public static ChargeLines Instance
        { get; } = new ChargeLines();

        public static void RemoveByOrderLineId(OrderLineIdentifier id)
        {
            var aa = Instance.ToList().Find(x => x.id == id);
            if (aa == null)
                return;
            Instance.Remove(aa);
        }
    }
}
