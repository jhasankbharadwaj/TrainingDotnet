using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MvcEntitycore.Models
{
    public class EmployeeTable
    {

        [ForeignKey("employeeID")]
        [Key]
        public int EmpId { get; set; }
        public string? Name { get; set; }
        public int? Experience { get; set; }

        public int Eventid { get; set; }

        //navigation property . 
        public ICollection<Event>? Events { get; set; }
    }
}
