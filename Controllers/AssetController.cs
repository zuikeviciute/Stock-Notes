using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

using stock_notes.Models;
using StocksEntities;
using StocksContext;
using System.Reflection.Emit;

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

            List<DataPointViewModel> dataPoints = new List<DataPointViewModel>();

            foreach(OHLC ohlc in model.OHLC){
                dataPoints.Add(new DataPointViewModel(ohlc.date.Ticks, ohlc.close));
            }
 
			ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);
            
            return View(model);
        }
    }
}