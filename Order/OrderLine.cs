using Order.Aids;

namespace Order
{
    public class OrderLine
    {
        private string producttype;
        private int serialnumber;
        private int numberordered;
        private int unitprice;

        public string ProductType
        {
            get { return Str.EmptyIfNull(producttype); }
            set { producttype = value; }
        }
        public int SerialNumber { get; set; }
        public int NumberOrdered { get; set; }
        public int UnitPrice { get; set; }

        //klass olemas getOrderLineIdentifier() - Returns the OrderLineIdentifier—this is the unique identifier for the OrderLine
        //klassi pole vaja incrementNumberOrdered - Increments the number of ProductInstance recorded by the OrderLine
        //klassi ei ole vaja  getNumberOrdered() - Returns the number of ProductInstances recorded by the OrderLine
        //klassi ei ole vaja decrementNumberOrdered - Decrements the number of ProductInstances recorded by the OrderLine
        /*olemas */
        public void addDeliveryReceiver(DeliveryReceiver line)
        {
            
        }
        //mariliis addDeliveryReceiver - Adds a DeliveryReceiver to the OrderLine
        //mariliis getDeliveryReceiver() - Returns the DeliveryReceiver for this OrderLine
        // ei tea removeDeliveryReceiver - Removes the DeliveryReceiver from the OrderLine
        // Merilyn addTax(...) Adds tax (represented by a TaxOnLine) to the OrderLine
        //Merilyn getTaxes() - Returns all the TaxOnLines for this OrderLine
        // ei tea removeTax(...) Removes a TaxOnLine from the OrderLine
        public void addChargeLine(ChargeLine line)
        {
            ChargeLines.Instances.Add(line);
        }

        public ChargeLines getChargeLines()
        {
            //todo return ChargeLines.Instances.Select(x=>x.)
            return ChargeLines.Instances;
        } //Returns all the ChargeLines associated with this OrderLine

        
        // teeme ara removeChargeLine(...) Removes a ChargeLine from the OrderLine
        //ei tea clone() Makes a copy of the OrderLine and any associated objects that can be used to create an amended OrderLine







    }
}
