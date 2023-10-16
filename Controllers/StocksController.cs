using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

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
            return View(model);
        }

        public IActionResult Selected(String id)
        {
            StocksViewModel model = new StocksViewModel();
            StocksDatabase db = new StocksDatabase();
            
            model.OHLC = db.OHLC.Where(f => f.Symbol == id).ToList();
            model.assetName = db.Stocks.Single(f => f.Symbol == id).Security;
            model.ticker = id;

            //shows todays date, test with api data
            //DateOnly current = new DateOnly(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);

            DateOnly current = new DateOnly(2023, 09, 07);
            model.closePrice = model.OHLC.Single(f => f.date == current).close;

            List<DataPointViewModel> dataPoints = new List<DataPointViewModel>();

            foreach(OHLC ohlc in model.OHLC){
                if(ohlc.date.Year == 2023){
                    dataPoints.Add(new DataPointViewModel(ohlc.date.DayOfYear, ohlc.close, ohlc.date.ToString()));
                }
            }
 
			ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);
            
            return View(model);
        }
    }
}