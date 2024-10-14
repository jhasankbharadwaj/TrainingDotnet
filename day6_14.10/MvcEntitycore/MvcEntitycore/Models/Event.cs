namespace MvcEntitycore.Models
{
    public class Event
    {
        public Event() { }
        public int EventId { get; set; }
        public string EventName { get; set; }

        public ICollection<Employee> Events { get; set; }

    }
}
