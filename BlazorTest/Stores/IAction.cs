using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Stores
{
    public interface IAction
    {
        public string Name { get; }
    }
}
