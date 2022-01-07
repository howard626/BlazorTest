using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Models
{
    public class Employee
    {
        public int 編號 { get; set; }
        public string 姓名 { get; set; }
        public string 職位 { get; set; }
        public string 公司 { get; set; }

        public List<Employee> LoadRecords() 
        {
            //do somthing
            var employees = new List<Employee>();
            employees.Add(this);
            return employees;
        }
    }
}
