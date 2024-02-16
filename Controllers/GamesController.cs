using Microsoft.AspNetCore.Mvc;

namespace AppLearn.Controllers
{
    public class GamesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
