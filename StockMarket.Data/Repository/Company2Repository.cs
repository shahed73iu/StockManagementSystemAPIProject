using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockMarket.Data.Entity;

namespace StockMarket.Data.Repository
{
    public class Company2Repository : ICompany2Repository
    {
        private StockMarketContext _context;
        public Company2Repository(StockMarketContext context)
        {
            _context = context;
        }
        public void CreateACompany(Company2 company2)
        {
            _context.Company2s.Add(new Company2()
            {
                Name= company2.Name,
                Symbol= company2.Symbol
            });
            _context.SaveChanges();
        }

        public void DeleteACompany(string Symbol)
        {
                var companys = _context.Company2s.Where(x => x.Symbol == Symbol).FirstOrDefault();
                _context.Company2s.Remove(companys);
                _context.SaveChanges();
        }

        public Company2 ShowACompany(string Symbol)
        {
            return _context.Company2s.Where(x => x.Symbol == Symbol).FirstOrDefault();
        }

        public List<Company2> ShowAllCompanies()
        {
            return _context.Company2s.ToList();
        }

        public void UpdateACompany(string Symbol, Company2 company2)
        {
            var updateCompany2 = _context.Company2s.Where(x => x.Symbol == Symbol).FirstOrDefault();

            updateCompany2.Name = company2.Name;
            updateCompany2.Symbol= company2.Symbol;
            _context.SaveChanges();
        }
    }
}
