using Microsoft.AspNetCore.Mvc;
using PackagingAndDelivery.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PackagingAndDelivery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackagingAndDeliveryController : ControllerBase
    {
        private readonly IRepo _repo;
        public PackagingAndDeliveryController(IRepo repo)
        {
            _repo = repo;   
        }
        [HttpGet]
        public ActionResult<double> PackagingDeliveryCharge(string item,int count)
        {
            double total = _repo.PackagingDeliveryCharge(item, count);
            return Ok(total);
        }
        // GET api/<PackagingAndDeliveryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PackagingAndDeliveryController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PackagingAndDeliveryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PackagingAndDeliveryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
