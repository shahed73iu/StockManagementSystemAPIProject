using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.Data.Entity;
using StockMarket.Data.Service;

namespace StockMarket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private IStockService _stockService; 
        public StockController (IStockService stockService)
        {
            _stockService = stockService;
        }

        // GET api/Stock/gp
        [HttpGet]
        public ActionResult<List<StockPrice>> Get(string Symbol)
        {
            return _stockService.ShowAllStocksSer(Symbol);
        }

        // GET api/Stock/gp/StartDate/EndDate
        [HttpGet("/api/Stock/{symbol}/{start}/{end}")]
        public ActionResult<List<StockPrice>>Get(string Symnbol, DateTime Start , DateTime End)
        {
            return _stockService.ShowSpecificStockRecordsSer(Symnbol, Start, End);
        }

        // POST api/Stock
        [HttpPost]
        public void Post([FromBody] StockPrice stockPrice)
        {
            _stockService.CreateAStockRecordSer(stockPrice);
        }

        // PUT api/Stock/gp
        [HttpPut("/api/Stock/{Symbol}")]
        public void Put([FromBody] StockPrice stockPrice)
        {
            _stockService.UpdateStockInfoSer(stockPrice);
        }

        // DELETE api/Stock/gp
        [HttpDelete("/api/Stock/{Symbol}")]
        public void Delete(string Symbol)
        {
            _stockService.DeletesAllStockDataInformationForThatCompanySer(Symbol);
        }

        // DELETE api/Stock/gp/Date
        [HttpDelete("/api/Stock/{Symbol}/{Date}")]
        public void Delete(string Symbol , DateTime Date)
        {
            _stockService.DeletesStockDataSpecificDayInformationSer(Symbol, Date);
        }

    }
}