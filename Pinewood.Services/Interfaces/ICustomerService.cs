using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pinewood.Models;

namespace Pinewood.Services.Interfaces
{
    public interface ICustomerService
    {
        public IEnumerable<Customer> GetCustomers();
        public void AddCustomer(Customer customer);
        public void UpdateCustomer(Customer customer);
        public void DeleteCustomer(int id);
    }
}
