using YouBook.Models;

namespace YouBook.Services
{
    public interface IMeetingDomainService
    {
        Meeting GetMeetingById(int id);
    }
}