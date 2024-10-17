using System.ComponentModel.DataAnnotations.Schema;

namespace MvcEntitycore.Models
{
    public class Event
    {
        public int Id { get; set; }

        [ForeignKey("EventId")]

        public int? EventId { get; set; }
        public string? EventName { get; set; }

        public ICollection<EmployeeTable>? Events { get; set; }

    }
}
