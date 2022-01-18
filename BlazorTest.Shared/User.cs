using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Shared
{
    public class User: LoginModel
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public int Id { get; set; }
        public string Phone { get; set; }
    }
}
