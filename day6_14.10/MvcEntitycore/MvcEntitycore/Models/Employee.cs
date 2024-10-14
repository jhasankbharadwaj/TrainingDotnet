using Microsoft.Extensions.Logging;

namespace MvcEntitycore.Models
{
    public class Employee
    {
        public Employee() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Experience { get; set; }

        //navigation property . 
        public ICollection<Event> Events { get; set; }
    }
}
