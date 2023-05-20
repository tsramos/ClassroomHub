using Microsoft.AspNetCore.Mvc;

namespace ClassroomHub.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
