using StockMarket.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Data
{
    public class StockMarket2UnitofWork : IStockMarket2UnitofWork
    {
        private StockMarketContext _context;

        public IStockRepository StockRepository { get; private set; }
        public ICompany2Repository Company2Repository {get; private set; }
        public StockMarket2UnitofWork(string connectionString , string migrationAssemblyName)
        {
            _context = new StockMarketContext(connectionString, migrationAssemblyName);

            StockRepository = new StockRepository(_context);
            Company2Repository = new Company2Repository(_context);
        }


        public void save()
        {
            _context.SaveChanges();
        }
    }
}
