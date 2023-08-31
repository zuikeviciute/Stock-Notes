using System;
using System.ComponentModel.DataAnnotations;

namespace StocksEntities
{
    public class Stocks
    {
        [Key]
        public String Symbol { get; set; }
        public String Security { get; set; }
        public String GICS_Sector { get; set; }
        public String GICS_SubIndustry { get; set; }
        public String Headquarters_Location { get; set; }
        public String Date_added { get; set; }
        public Int32 CIK { get; set; }
        public String Founded { get; set; }
    }

    public class OHLC
    {
        [Key]
        public Int32 entryID { get; set; }
        public String date { get; set; }
        public float open { get; set; }
        public float high { get; set; }
        public float low { get; set; }
        public float close { get; set; }
        public float adjCLose { get; set; }
        public Int32 Volume { get; set; }
        public String Symbol { get; set; }
    }
}