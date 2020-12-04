using StockMarket.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Data.Repository
{
    public interface ICompany2Repository    
    {
        List<Company2> ShowAllCompanies();
        Company2 ShowACompany(string Symbol);
        void CreateACompany(Company2 company2);
        void UpdateACompany(string Symbol, Company2 company2);
        void DeleteACompany(string Symbol);
    }
}
