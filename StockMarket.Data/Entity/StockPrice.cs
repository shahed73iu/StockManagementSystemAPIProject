using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Data.Entity
{
    public class StockPrice
    {
        public int Id { get; set; }
        public Company2 Company2 { get; set; }
        public int ComapnyId { get; set; }
        public DateTime TradingDay  { get; set; }
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; } 
    }
}
