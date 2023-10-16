using System;
using System.Collections.Generic;
using System.Linq;

using StocksContext;
using StocksEntities;

namespace stock_notes.Models
{
    public class StocksViewModel
    {
        public List<Stocks> Stocks {get; set;}
        public List<OHLC> OHLC {get; set;}
        public string assetName {get; set;}
        public String ticker {get; set;}
        public float closePrice {get; set;}
    }
}