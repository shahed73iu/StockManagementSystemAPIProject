using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Data.Entity
{
    public class Company2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol  { get; set; }
        public List<StockPrice> StockPrices { get; set; }
    }
}
