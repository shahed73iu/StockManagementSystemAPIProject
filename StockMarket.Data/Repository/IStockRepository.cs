using StockMarket.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Data.Repository
{
    public interface IStockRepository
    {
        List<StockPrice> ShowAllStocks(Company2 company2);
        List<StockPrice> ShowSpecificStockRecords(Company2 company2, DateTime start, DateTime end);
        void CreateAStockRecord(StockPrice stockPrice);
        void UpdateStockInfo(StockPrice stockPrice);
        void DeletesAllStockDataInformationForThatCompany(Company2 company2);
        void DeletesStockDataSpecificDayInformation(Company2 company2, DateTime date);
    }
}


