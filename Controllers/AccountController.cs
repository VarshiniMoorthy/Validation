using System.Web.Mvc;
using Account.Entity;

namespace OnlineShopping.Controllers
{
    public class AccountController : Controller
    {
       
        public ActionResult Login()
        {
           
            return View();
        }
        public ActionResult SignUp()
        {
            ViewBag.Cities = new SelectList("City");
            return View();
        }
    }
}