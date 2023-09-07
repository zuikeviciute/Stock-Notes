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
        public DataPointViewModel(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "x")]
        public Nullable<float> X = null;

        //Explicitly setting the name to be used while serializing to JSON.
        [DataMember(Name = "y")]
        public Nullable<float> Y = null;
    }
}