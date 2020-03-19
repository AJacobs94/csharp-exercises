using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        // static private List<User> Users = new List<User>();
        // GET: /<controller>/
        private static string error = null;
        public IActionResult Index()
        {
            ViewBag.users = UserData.GetAll();
            return View();
        }

        [HttpGet]
       public IActionResult Add()
        {
            ViewBag.title = "Add User";
            ViewBag.error = error;

            return View();
        }


       
        [HttpPost]
        public IActionResult Add(User user, string confirm)
        {
            if ((string.IsNullOrEmpty(user.Password)) || (string.IsNullOrEmpty(confirm)))
            {
                error = "Passwords cannot be empty.";
                return Redirect("/User/Add");
            }
            if (user.Password != confirm)
            {
                error ="Passwords do not match";
                return Redirect("/User/Add");
            }
            else
            {
                UserData.Add(user);
            }
            error = null;
            return Redirect("/User");
            
        }

        
        [HttpGet]
        public IActionResult DisplayDetail(int userId)
        {
            ViewBag.title = "User Detail";
            ViewBag.user = UserData.GetById(userId);
            return View();

        }
        
    }
}
