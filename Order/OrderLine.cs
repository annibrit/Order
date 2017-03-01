using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class OrderLine
    {
        public String productType;
        public int serialNumber;
        public int numberOrdered;

        //getOrderLineIdentifier() - Returns the OrderLineIdentifier—this is the unique identifier for the OrderLine
        //incrementNumberOrdered - Increments the number of ProductInstance recorded by the OrderLine
        //getNumberOrdered() - Returns the number of ProductInstances recorded by the OrderLine
        //decrementNumberOrdered - Decrements the number of ProductInstances recorded by the OrderLine
        //addDeliveryReceiver - Adds a DeliveryReceiver to the OrderLine
        //getDeliveryReceiver() - Returns the DeliveryReceiver for this OrderLine
        //removeDeliveryReceiver - Removes the DeliveryReceiver from the OrderLine
        //addTax(...) Adds tax (represented by a TaxOnLine) to the OrderLine
        //getTaxes() - Returns all the TaxOnLines for this OrderLine
        //removeTax(...) Removes a TaxOnLine from the OrderLine
        //addChargeLine(...) Adds a ChargeLine to the OrderLine
        //getChargeLines() Returns all the ChargeLines associated with this OrderLine
        //removeChargeLine(...) Removes a ChargeLine from the OrderLine
        //clone() Makes a copy of the OrderLine and any associated objects that can be used to create an amended OrderLine

    }
}
