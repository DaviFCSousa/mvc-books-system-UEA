using LibraryManager.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.Controllers
{
    public class LoginController : Controller
    {

        public void xx()
        {
            this.HttpContext.Session.SetInt32("LoggedIn", 1);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (username == "admin@gmail.com" && password == "123")
            {
                

                return RedirectToAction("Index", "Home");
            }
            else
            {
               
                ViewBag.ErrorMessage = "Usuário ou senha inválidos";
                return View();
            }


        }

      }
 
}
