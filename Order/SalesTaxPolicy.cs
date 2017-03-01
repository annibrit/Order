using Order.Aids;

namespace Order
{

    public class SalesTaxPolicy

    {
        private string taxtype;

        public string TaxType
        {
            get { return Str.EmptyIfNull(taxtype); }
            set { taxtype = value; }
        }

        public double Rate
        {
            get;
            set;
        }
    }
}
