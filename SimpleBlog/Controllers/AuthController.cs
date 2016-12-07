using System.Web.Mvc;
using System.Web.Security;
using SimpleBlog.ViewModels;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Login()
        {
            return View(new AuthLogin
            {
                Test = "This is my test value set in my controller!"
            });
        }

        [HttpPost]
        public ActionResult Login(AuthLogin form)
        {
            if (!ModelState.IsValid)
                return View(form);

            FormsAuthentication.SetAuthCookie(form.Username, true);


//            if (form.Username != "rainbow dash")
//            {
//                ModelState.AddModelError("Username", "Username or password isn't 20% cooler.");
//                return View(form); 
//            } 

            return Content("The form is valid!");
        }
    }   
}