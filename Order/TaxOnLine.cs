using Order.Aids;

namespace Order
{
    public class TaxOnLine
    {

        private string type;
        private string comment;
        //taxationRate:Real
        public TaxOnLine tax { get; set; }

        public double Rate { get; set; }

        public string Type
        {
            get { return Str.EmptyIfNull(type); }
            set { type = value; }
        }

        public string Comment
        {
            get { return Str.EmptyIfNull(comment); }
            set { comment = value; }
        }   
    }
}
