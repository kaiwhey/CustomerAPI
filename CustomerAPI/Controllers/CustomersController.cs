using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CustomerAPI.Models;

namespace CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        Customer[] customers = new Customer[]
        {
            new Customer{ID = 1, Name = "Darius", Age = 44, Email = "dar@snailmail.com" },
            new Customer{ID = 2, Name = "Nebo", Age = 65, Email = "neb@snailmail.com"},
            new Customer{ID = 3, Name = "Apollo", Age = 22, Email = "pol@snailmail.com"},
            new Customer{ID = 4, Name = "Jester", Age = 35, Email = "jest@snailmail.com"}
        };

        // GET: api/Customers
        [HttpGet]
        public IEnumerable<Customer> GetCustomer()
        {
            return customers;
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public ActionResult<Customer> GetCustomer(int id)
        {
            var customer = customers.FirstOrDefault((p) => p.ID == id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }
        
    }
}
