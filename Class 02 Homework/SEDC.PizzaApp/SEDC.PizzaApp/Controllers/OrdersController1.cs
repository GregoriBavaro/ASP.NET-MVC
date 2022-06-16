using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Controllers
{
    public class OrdersController : Controller
    {

        [Route("ListOrders")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Empty()
        {
            return new EmptyResult();
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Empty");
            }

            Orders orders = OrdersDb.Orders.FirstOrDefault(x => x.Id == id);
            if (orders == null)
            {
                return RedirectToAction("Empty");
            }

            return View(orders);
        }

        [Route("JsonData")]
        public IActionResult GetJson()
        {
            Orders order = new Orders()
            {
                Id = 3,
                Price = 400,
                RecipientPhoneNumber = 070245678,
                RecipientName = "Alek",
                RecipientAdress = "Partizanski Odredi Br12 c",
                NameOfOrder = "Capri"
            };
            return new JsonResult(order);
        }

        public IActionResult Redirect()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
