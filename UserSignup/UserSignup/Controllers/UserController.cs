using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;
using UserSignup.ViewModels;

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
            AddUserViewModel model = new AddUserViewModel
            {
                Users = UserData.GetAll()
            };
            return View(model);
        }

        
       public IActionResult Add()
        {
            AddUserViewModel addModel = new AddUserViewModel();

            return View(addModel);
        }


       
        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            
            if (ModelState.IsValid)
            {
                User user = new User()
                {
                    Name= addUserViewModel.Name,
                    Email=addUserViewModel.Email,
                    Password=addUserViewModel.Password

                };
                UserData.Add(user);
                return Redirect("/User");
            }
            return View(addUserViewModel);
            
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
