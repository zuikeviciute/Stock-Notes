using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using stock_notes.Models;
using StocksEntities;
using StocksContext;

namespace stock_notes.Controllers
{
    public class AssetController : Controller
    {
        //Function used to get albums and artist list and sort the artist list
        public IActionResult Index(String id)
        {
            AssetViewModel model = new AssetViewModel();
            StocksDatabase db = new StocksDatabase();

            //model.Stocks = db.Stocks.ToList();
            //model.OHLC = db.OHLC.ToList();
            
            model.OHLC = db.OHLC.Where(f => f.Symbol == id).ToList();
            model.assetName = db.Stocks.Single(f => f.Symbol == id).Security;
            model.ticker = id;
            return View(model);
        }
    }
}