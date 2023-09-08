using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

using StocksContext;
using StocksEntities;

namespace stock_notes.Models
{
    [DataContract]
    public class DataPointViewModel
    {
        public DataPointViewModel(long x, float y, DateTime label)
        {
            this.X = x;
            this.Y = y;
            this.Label = label;
        }

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "x")]
        public Nullable<long> X = null;

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "y")]
        public Nullable<float> Y = null;

        [DataMember(Name = "label")]
        public Nullable<DateTime> Label = null;
    }
}