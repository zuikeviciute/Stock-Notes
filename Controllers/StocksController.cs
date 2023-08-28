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
    public class StocksController : Controller
    {
        //Function used to get albums and artist list and sort the artist list
        public IActionResult Index()
        {
            StocksViewModel model = new StocksViewModel();
            StocksDatabase db = new StocksDatabase();
            model.Stocks = db.Stocks.ToList();
            model.OHLC = db.OHLC.ToList();
            //model.Artists.Sort((x, y) => string.Compare(x.Name, y.Name));
            return View(model);
        }
    }
}