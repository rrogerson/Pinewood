using Pinewood.Models;
using Pinewood.Services.Interfaces;

namespace Pinewood.Services
{
    public class CustomerService : ICustomerService
    {
        public void AddCustomer(Customer customer)
        {
            var maxId = CustomerData.CustomerList.Max(x => x.Id);
            customer.Id = maxId + 1;
            CustomerData.CustomerList.Add(customer);
        }

        public void DeleteCustomer(int id)
        {
            Customer? customer = CustomerData.CustomerList.ToList().Find(x => x.Id == id);
            if (customer != null)
            {
                CustomerData.CustomerList.Remove(customer);

            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return CustomerData.CustomerList;
        }

        public void UpdateCustomer(Customer customer)
        {
            var originalCustomer = CustomerData.CustomerList.FirstOrDefault(x => x.Id == customer.Id);
            if (originalCustomer != null)
            {
                var indexOf = CustomerData.CustomerList.IndexOf(CustomerData.CustomerList.Find(p => p.Id == customer.Id));
                CustomerData.CustomerList[indexOf] = customer;
            }
        }
    }
}
