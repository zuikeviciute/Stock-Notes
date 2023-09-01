using System;
using System.Collections.Generic;
using System.Linq;

using StocksContext;
using StocksEntities;

namespace stock_notes.Models
{
    public class AssetViewModel
    {
        public List<Stocks> Stocks {get; set;}
        public List<OHLC> OHLC {get; set;}
        public String assetName {get; set;}
        public String ticker {get; set;}
        public LinkedList<String> date {get; set;}
        public LinkedList<float> close {get; set;}
    }
}