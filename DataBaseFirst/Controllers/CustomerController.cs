using DataBaseFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DataBaseFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AdventureWorksLt2017Context _context;
        public CustomerController(AdventureWorksLt2017Context context)
        {
            _context = context;
        }

        
        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetCustumers()
        {
            List<Customer> customers = await _context.Customers.ToListAsync();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustumer(int id)
        {
            Customer customer = await _context.Customers.FindAsync(id);
            return Ok(customer);
        }

    }
}
