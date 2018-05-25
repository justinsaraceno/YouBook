using System;

namespace YouBook.Models
{
    public class Meeting
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime ScheduledDate { get; set; }
    }
}