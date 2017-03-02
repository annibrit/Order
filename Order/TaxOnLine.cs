﻿using Order.Aids;

namespace Order
{
    public class TaxOnLine
    {

        private string taxationtype;
        private string comment;
        //taxationRate:Real

        public double Rate { get; set; }

        public string taxationType
        {

            get { return Str.EmptyIfNull(taxationtype); }
            set { taxationtype = value; }
        }

        public string Comment
        {
            get { return Str.EmptyIfNull(comment); }
            set { comment = value; }
        }   
    }
}
