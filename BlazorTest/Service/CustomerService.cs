using BlazorTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Service
{
    public class CustomerService :ICustomerService
    {
        private List<Customer> customers;
        public string Uid { get; set; }
        public CustomerService() 
        {
            Uid = Guid.NewGuid().ToString();

            customers = new List<Customer>()
            {
                new Customer{ Id = 1, Name = "壹"},
                new Customer{ Id = 2, Name = "貳"},
                new Customer{ Id = 3, Name = "參"},
                new Customer{ Id = 4, Name = "肆"},
                new Customer{ Id = 5, Name = "伍"},
                new Customer{ Id = 6, Name = "陸"},
                new Customer{ Id = 7, Name = "柒"}
            };
        }

        public Customer GetCustomerById(int id) 
        {
            return customers.FirstOrDefault(c => c.Id == id);
        }
    }
}
