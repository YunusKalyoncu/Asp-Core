using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RealEstate.DataAccessLayer.Concrete;
using RealEstate.EntityLayer.Concrete;
using System.Linq;

namespace RealEstate.PresentationLayer.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        Context context = new Context();
        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }
        public IActionResult DeleteUser(int id)
        {
            var values = context.Find<AppUser>(id);
            context.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UptadeUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UptadeUser(int id)
        {
            var values = context.Find<AppUser>(id);
            context.Update(values);
            context.SaveChanges();
            return View();
        }

    }
}
