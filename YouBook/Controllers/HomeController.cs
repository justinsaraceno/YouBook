using System.Web.Mvc;
using YouBook.Services;

namespace YouBook.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMeetingDomainService meetingDomainService;

        public HomeController(IMeetingDomainService meetingDomainService)
        {
            this.meetingDomainService = meetingDomainService;
        }
        
        public ActionResult Index()
        {
            var meeting = meetingDomainService.GetMeetingById(123);
            ViewBag.Message = meeting.Description;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}