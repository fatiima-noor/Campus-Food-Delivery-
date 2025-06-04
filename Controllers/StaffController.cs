using Microsoft.AspNetCore.Mvc;

namespace CampusFoodDelivery.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult StaffDashboard()
        {
            return View(); 
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddFoodItem()
        {
            return View();
        }

        public IActionResult ManageFoodItems()
        {
            return View();
        }

        public IActionResult ViewOrders()
        {
            return View();
        }
    }
}
