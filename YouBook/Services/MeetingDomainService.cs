using System;
using YouBook.Models;

namespace YouBook.Services
{
    public class MeetingDomainService : IMeetingDomainService
    {
        public Meeting GetMeetingById(int id)
        {
            return new Meeting{ Id = id, Description = "This is the concrete meeting", ScheduledDate = new DateTime(2018, 05, 24)};
        }
    }
}