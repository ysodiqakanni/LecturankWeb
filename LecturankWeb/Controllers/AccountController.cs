using LecturankWeb.Models;
using LecturankWeb.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace LecturankWeb.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(AccountViewModel model)
        {
            var dbmodel = new Account();
            try
            {
                if (ModelState.IsValid)
                {
                    dbmodel.FirstName = model.FirstName;
                    dbmodel.LastName = model.LastName;
                    dbmodel.Email = model.Email;
                    dbmodel.Password = model.Password;

                    //Then Add the dbmodel to the Database
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AccountViewModel model)
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
