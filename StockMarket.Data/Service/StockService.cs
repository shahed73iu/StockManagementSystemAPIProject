using StockMarket.Data.Entity;
using StockMarket.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Data.Service
{
    public class StockService : IStockService
    {
        private StockMarket2UnitofWork _stockMarket2UnitofWork;
        
        public StockService(StockMarket2UnitofWork stockMarket2UnitofWork)
        {
            _stockMarket2UnitofWork = stockMarket2UnitofWork;
        }

        public void CreateAStockRecordSer(StockPrice stockPrice)
        {
            _stockMarket2UnitofWork.StockRepository.CreateAStockRecord(stockPrice);
        }

        public void DeletesAllStockDataInformationForThatCompanySer(string symbol)
        {
            var company = _stockMarket2UnitofWork.Company2Repository.ShowACompany(symbol);
            if(company!=null)
            {
              _stockMarket2UnitofWork.StockRepository.DeletesAllStockDataInformationForThatCompany(company);
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public void DeletesStockDataSpecificDayInformationSer(string symbol, DateTime date)
        {
            var company =_stockMarket2UnitofWork.Company2Repository.ShowACompany(symbol);

            if(company!= null)
            {
              _stockMarket2UnitofWork.StockRepository.DeletesStockDataSpecificDayInformation(company , date);
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public List<StockPrice> ShowAllStocksSer(string symbol)
        {
            var company2instance =_stockMarket2UnitofWork.Company2Repository.ShowACompany(symbol);
            if(company2instance != null)
            {
                return _stockMarket2UnitofWork.StockRepository.ShowAllStocks(company2instance);
            }
            else
            {
                throw new NullReferenceException();
            }
        }

        public List<StockPrice> ShowSpecificStockRecordsSer(string symbol, DateTime start, DateTime end)
        {
            var company2instance =_stockMarket2UnitofWork.Company2Repository.ShowACompany(symbol);
            if (company2instance != null)
            {
                return _stockMarket2UnitofWork.StockRepository.ShowSpecificStockRecords(company2instance, start, end);
            }
            else
            {
                throw new NullReferenceException();
            }

        }

        public void UpdateStockInfoSer(StockPrice stockPrice)
        {
           _stockMarket2UnitofWork.StockRepository.UpdateStockInfo(stockPrice);
        }
    }
}
