using Microsoft.AspNetCore.Mvc;

namespace GETRI_StronlyTypeViews.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
