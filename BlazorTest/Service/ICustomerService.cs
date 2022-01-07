using BlazorTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Service
{
    public interface ICustomerService
    {
        public string Uid { get; set; }
        public Customer GetCustomerById(int id);
    }
}
