using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CRM_Mini.Controllers
{
    [Authorize(Roles = "Admin,User")]
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            // Placeholder for customer detail logic
            return View();
        }
    }
}