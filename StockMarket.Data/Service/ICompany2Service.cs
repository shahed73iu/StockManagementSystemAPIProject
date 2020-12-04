using StockMarket.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.Data.Service
{
    public interface ICompany2Service
    {
        List<Company2> ShowAllCompaniesSer();
        Company2 ShowACompanySer(string Symbol);
        void CreateACompanySer(Company2 company2);
        void UpdateACompanySer(string Symbol, Company2 company2);
        void DeleteACompanySer(string Symbol);
    }
}
