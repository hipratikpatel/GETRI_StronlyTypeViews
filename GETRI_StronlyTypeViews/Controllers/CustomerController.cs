using GETRI_StronlyTypeViews.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETRI_StronlyTypeViews.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            List<Customer> lstCustomer = new List<Customer>
            {
                new Customer
                {
                    CustomerId=1,CustomerName="Tejas",CustomerAddress="Rajkot",CustomerPhone="123456"
                },
                new Customer
                {
                    CustomerId=2,CustomerName="Saurabh",CustomerAddress="Vidhyut Nagar",CustomerPhone="654321"
                },
                new Customer
                {
                    CustomerId=3,CustomerName="Amit",CustomerAddress="Kalali",CustomerPhone="456789"
                },
                new Customer
                {
                    CustomerId=4,CustomerName="Pratik",CustomerAddress="Gotri",CustomerPhone="987654"
                }
            };
            return View(lstCustomer);
        }
    }
}
