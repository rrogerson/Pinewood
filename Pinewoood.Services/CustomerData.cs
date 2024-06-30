using Pinewood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pinewood.Services
{
    public static class CustomerData
    {
        static CustomerData()
        {
            CustomerList =
                [
                    new Customer { Id = 1, FirstName = "Ruth", LastName = "Rogerson", Email="ruth.rogerson@email.com", Address = "17 Warwick Way", City="Rugby"},
                    new Customer { Id = 2, FirstName = "John", LastName = "Smith", Email="john.smith@hotmail.com", Address = "1 London Road", City="London"}

                ];
        }

        public static List<Customer> CustomerList { get; set; }
    }
}
