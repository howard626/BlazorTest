using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.BaseComponent
{
    public class DateBaseComponent : ComponentBase
    {
        public DateBaseComponent() 
        {
            dateTime = DateTime.Now;
        }
        public DateTime dateTime { get; set; }
    }
}
