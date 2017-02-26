using Order.Aids;

namespace Order
{
    public class Discount
    {
        public string reason;

        public string Reason
        {

            get { return Str.EmptyIfNull(reason); }
            set { reason = value; }
        }
    }
}

