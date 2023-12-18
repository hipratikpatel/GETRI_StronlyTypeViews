using GETRI_StronlyTypeViews.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETRI_StronlyTypeViews.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Employee employee = new Employee()
            {
                EmpId = 1,
                EmpName = "Test",
                EmpSal = 10
            };

            return View(employee);
        }
    }
}
