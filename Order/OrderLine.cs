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
        public int ProductInstance { get; set; }

             public void getOrderLineIdentifier()
             {
                 //return OrderLineIdentifier();
             } //Returns the OrderLineIdentifier—this is the unique identifier for the OrderLine
        /*
         * 
         * Stackist:
                 * public class MyClass
            {
        public  static int countinstance  =0;
        MyClass(){ countinstance  ++;}
         ~ MyClass() {countinstance  --; }
            }


             public void getNumberOrdered() {
             return ProductInstances
             }
            - Returns the number of ProductInstances recorded by the OrderLine

             public void incrementNumberOrdered() {
             ProductInstances++
                }
             Increments the number of ProductInstance recorded by the OrderLine

             public void decrementNumberOrdered() {
             ProductInstances--
                }   
             
             Decrements the number of ProductInstances recorded by the OrderLine

         */
        public void AddDeliveryReceiver(DeliveryReceiver reciever)
        {
            DeliveryReceivers.Instances.Add(reciever);
        }

        public DeliveryReceivers GetDeliveryReceiver()
        {
            //todo return DeliveryReceivers.Instances.Select(x=>x.)
            return DeliveryReceivers.Instances;
        } //Returns the DeliveryReceiver for this OrderLine


        public void RemoveDeliveryReceiver()
        {
            // DeliveryReceivers.Instances.Remove(?);
        } //Removes the DeliveryReceiver from the OrderLine


        public void AddTax(TaxOnLine tax)
        {
            TaxOnLines.Instances.Add(tax);
        }

        public TaxOnLines GetTaxes()
        {
            //todo return TaxOnLines.Instances.Select(x=>x.)
            return TaxOnLines.Instances;
        } //Returns all the TaxOnLines for this OrderLine

        public void RemoveTax()
        {
          // TaxOnLines.Instances.Remove(?);
        } //Removes a TaxOnLine from the OrderLine
        public void AddChargeLine(ChargeLine line)
        {
            ChargeLines.Instances.Add(line);
        }

        public ChargeLines GetChargeLines()
        {
            //todo return ChargeLines.Instances.Select(x=>x.)
            return ChargeLines.Instances;
        } //Returns all the ChargeLines associated with this OrderLine

        public void RemoveChargeLine()
        {
            // ChargeLines.Instances.Remove(?);
        } //Removes a ChargeLine from the OrderLine

        public OrderLine Clone()
        {
            return new OrderLine();
        } //Makes a copy of the OrderLine and any associated objects that can be used to create an amended OrderLine
    }
}
