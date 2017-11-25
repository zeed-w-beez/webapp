using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp2.Controllers.Apis
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Produces("application/json")]
    [Route("api/Seven")]
    public class SevenController : Controller
    {
        // GET: api/Seven
        [HttpGet]
        public IEnumerable<SevenModel> Get(int startIndex)
        {
            var rdm = new Random();
            return Enumerable.Range(1, 5).Select(index => new SevenModel
            {
                Issue = index + startIndex,
                Number = rdm.Next(1, 16),
                Date = DateTime.Now.AddDays(index + startIndex).ToString("d")
            });

            // return new string[] { "value1", "value2" };
        }

        // GET: api/Seven/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}
        
        // POST: api/Seven
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Seven/5
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

    public class SevenModel
    {
        public int Issue { get; set; }
        public int Number { get; set; }
        public string Date { get; set; }
    }
}
