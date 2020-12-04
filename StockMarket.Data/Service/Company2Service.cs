using System;
using System.Collections.Generic;
using System.Text;
using StockMarket.Data.Entity;
using StockMarket.Data.Repository;

namespace StockMarket.Data.Service
{
    public class Company2Service : ICompany2Service
    {

        private ICompany2Repository _company2Repository;
        public  Company2Service(ICompany2Repository company2Repository)
        {
            _company2Repository = company2Repository;
        }
                                                         
        public void CreateACompanySer(Company2 company2)
        {
            _company2Repository.CreateACompany(company2);
        }
                                                    
        public void DeleteACompanySer(string Symbol)
        {
            _company2Repository.DeleteACompany(Symbol);
        }
                                                  
        public Company2 ShowACompanySer(string Symbol)
        {
            return _company2Repository.ShowACompany(Symbol);
        }

        public List<Company2> ShowAllCompaniesSer()
        {
            return _company2Repository.ShowAllCompanies();
        }

        public void UpdateACompanySer(string Symbol, Company2 company2)
        {
            _company2Repository.UpdateACompany(Symbol, company2);
        }
    }
}
