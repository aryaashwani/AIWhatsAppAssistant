using Microsoft.AspNetCore.Mvc;

namespace AIWhatsAppAssistant.API.Controllers
{
    public class WebHookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
