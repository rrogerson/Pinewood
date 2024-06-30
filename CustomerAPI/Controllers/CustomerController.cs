using Microsoft.AspNetCore.Mvc;
using Pinewood.Models;
using System.Collections.Generic;
using System.Collections;
using Pinewood.Services.Interfaces;

namespace CustomerAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        //private List<Customer> _customers =
        //[
        //    new Customer { Id = 1, FirstName = "Ruth", LastName = "Rogerson", Email="ruth.rogerson@email.com", Address = "17 Warwick Way", City="Rugby"},
        //    new Customer { Id = 2, FirstName = "John", LastName = "Smith", Email="john.smith@hotmail.com", Address = "1 London Road", City="London"}
   
        //];


        private readonly ILogger<CustomerController> _logger;
        private ICustomerService _customerService;

        public CustomerController(ILogger<CustomerController> logger, ICustomerService customerService)
        {
            _logger = logger;
            _customerService = customerService;
        }

        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return _customerService.GetCustomers();
        }

        [HttpPost]
        public void AddCustomer(Customer customer)
        {
            try
            {
                _customerService.AddCustomer(customer);
            }
            catch
            {
                throw;
            }
        }

        [HttpPut]
        public void UpdateCustomer(Customer customer)
        {
            try
            {
                _customerService.UpdateCustomer(customer);

            }
            catch
            {
                throw;
            }
        }

        [HttpDelete("{id}")]
        public void DeleteCustomer(int id)
        {
            try
            {
                _customerService.DeleteCustomer(id);
            }
            catch
            {
                throw;
            }
        }
    }

   
}
