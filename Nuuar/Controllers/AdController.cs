using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Database.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Nuuar.Controllers
{
    [Produces("application/json")]
    [Route("api/Ad")]
    public class AdController : Controller
    {
        private readonly ApiContext _context;

        public AdController(ApiContext context)
        {
            _context = context;
        }


        //GET: api/Ad

        [HttpGet("[action]")]
        public IEnumerable<Ad> Get()
        {
            var ss = _context.Ad;
            return ss.ToList();
        }

        // GET: api/Ad/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Ad
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Ad/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
