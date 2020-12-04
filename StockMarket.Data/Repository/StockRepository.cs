using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockMarket.Data.Entity;

namespace StockMarket.Data.Repository
{
    public class StockRepository : IStockRepository
    {
        private StockMarketContext _context;
        public  StockRepository (StockMarketContext context)
        {
            _context = context;
        }

        public void CreateAStockRecord(StockPrice stockPrice)
        {
            var checkValidOrNot = _context.StockPrices.Where(x => x.ComapnyId == stockPrice.ComapnyId).FirstOrDefault();
            try
            {
                _context.StockPrices.Add(new StockPrice()
                {
                    ComapnyId= stockPrice.ComapnyId,
                    MaxPrice=stockPrice.MaxPrice,
                    MinPrice=stockPrice.MinPrice,
                    TradingDay=stockPrice.TradingDay,
                });
                _context.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void DeletesAllStockDataInformationForThatCompany(Company2 company2)
        {
            var stockPriceInstance = _context.StockPrices.Where(x => x.ComapnyId == company2.Id).FirstOrDefault();
            _context.StockPrices.Remove(stockPriceInstance);
            _context.SaveChanges();
        }

        public void DeletesStockDataSpecificDayInformation(Company2 company2, DateTime date)
        {
            var StockPriceInstance = _context.StockPrices.Where(x => x.ComapnyId == company2.Id && x.TradingDay ==date).FirstOrDefault();
            _context.StockPrices.Remove(StockPriceInstance);
            _context.SaveChanges();
        }

        public List<StockPrice> ShowAllStocks(Company2 company2)
        {
            return _context.StockPrices.Where(x => x.ComapnyId == company2.Id).ToList();
        }

        public List<StockPrice> ShowSpecificStockRecords(Company2 company2, DateTime start, DateTime end)
        {
            return _context.StockPrices.Where(x => x.ComapnyId == company2.Id && x.TradingDay >= start && x.TradingDay <= end).ToList();
        }

        public void UpdateStockInfo(StockPrice stockPrice)
        {
            var UpdateStockInfoInstance  = _context.StockPrices.Where(x => x.Id == stockPrice.Id).FirstOrDefault();

            UpdateStockInfoInstance.ComapnyId = stockPrice.ComapnyId;
            UpdateStockInfoInstance.MaxPrice = stockPrice.MaxPrice;
            UpdateStockInfoInstance.MinPrice = stockPrice.MinPrice;
            UpdateStockInfoInstance.TradingDay = stockPrice.TradingDay;
            _context.SaveChanges();
        }
    }
}
