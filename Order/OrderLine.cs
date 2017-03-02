using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class OrderLine
    {
        public string ProductType { get; set; }
        public int SerialNumber { get; set; }
        public int NumberOrdered { get; set; }
        public int UnitPrice { get; set; }

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
        public void addChargeLine(ChargeLine line)
        {
            ChargeLines.Instances.Add(line);
        }

        public ChargeLines getChargeLines()
        {
            //todo return ChargeLines.Instances.Select(x=>x.)
            return ChargeLines.Instances;
        } //Returns all the ChargeLines associated with this OrderLine
        //removeChargeLine(...) Removes a ChargeLine from the OrderLine
        //clone() Makes a copy of the OrderLine and any associated objects that can be used to create an amended OrderLine







    }
}
