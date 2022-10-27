using Microsoft.AspNetCore.Mvc;
using WebLayer.Models;

namespace WebLayer.Controllers
{
    public class ClienteController : Controller
    {   public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ClienteInsertViewModel viewModel)
        {
            bool isUnique = false;
            if (!isUnique)
            {
                ModelState.AddModelError("CPF", "CPF já esta em uso." +
                    "");
            }
            return View();

        }
    }
}
