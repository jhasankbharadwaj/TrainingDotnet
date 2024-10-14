using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkCore
{
    internal class Event
    {
        public Event() { }
        public int EventId {  get; set; }
        public string EventName { get; set; }

        public ICollection<Employee> Employees { get; set; }
    
    }
}
