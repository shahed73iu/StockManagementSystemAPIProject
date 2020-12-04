using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockMarket.Data.Entity;
using StockMarket.Data.Service;

namespace StockMarket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Comapany2Controller : ControllerBase
    {
        private ICompany2Service _company2Service;
        public Comapany2Controller(ICompany2Service company2Service)
        {
            _company2Service = company2Service;
        }


        // GET api/Company2
        [HttpGet]
        public ActionResult<List<Company2>> Get()
        {
            return _company2Service.ShowAllCompaniesSer();
        }
  


        // GET api/Company2/gp
        [HttpGet("/api/Company2/{Symbol}")]
        public ActionResult<Company2> Get(string Symbol)
        {
            return _company2Service.ShowACompanySer(Symbol);
        }

        // POST api/Company2
        [HttpPost]
        public void Post([FromBody] Company2 company2)
        {
            _company2Service.CreateACompanySer(company2);
        }

        // PUT api/Company2/gp
        [HttpPut("/api/Company2/{Symbol}")]
        public void Put(string Symbol, [FromBody] Company2 company2)
        {
            _company2Service.UpdateACompanySer(Symbol, company2);
        }

        // DELETE api/Company2/gp
        [HttpDelete("/api/Company2/{Symbol}")]
        public void Delete(string Symbol)
        {
            _company2Service.DeleteACompanySer(Symbol);
        }
    }
}