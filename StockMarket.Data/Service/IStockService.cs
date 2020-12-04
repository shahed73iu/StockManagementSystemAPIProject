using StockMarket.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Data.Service
{
    public interface IStockService
    {
        List<StockPrice> ShowAllStocksSer(string symbol);
        List<StockPrice> ShowSpecificStockRecordsSer(string symbol, DateTime start, DateTime end);
        void CreateAStockRecordSer(StockPrice stockPrice);
        void UpdateStockInfoSer(StockPrice stockPrice);       
        void DeletesAllStockDataInformationForThatCompanySer(string symbol);
        void DeletesStockDataSpecificDayInformationSer(string symbol, DateTime date);
    }
}
