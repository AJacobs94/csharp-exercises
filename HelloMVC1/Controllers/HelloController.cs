using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloMVC1.Controllers
{
    public class HelloController : Controller
    {
        

        // GET: /<controller>/
        public IActionResult Index()
        {
            string html = "<form method ='post'>"
                +"<input type= 'text' name= 'name'/>"
                + "<select id = 'language' name='language'>"
                +"<option value ='English'>English</option>"
                +"<option value = 'French'>French</option>"
                +"<option value = 'Romanian'>Romanian</option>"
                +"<option value = 'Spanish'>Spanish</option>"
                +"<option value = 'Italian'>Italian</option>"
                +"<option value = 'Hindi'>Hindi</option>"
               +" <select/>"
                +"<input type= 'submit' value= 'Greet me!'/>"
                +"<form/>";
            return Content(html,"text/html");
        }

        public IActionResult CreateMessage(string name, string language)
        {
            string greeting;
            if (language == "English") 
            {
                greeting = "Hello, " + name + "!";
            }
           else if (language == "French")
            {
                greeting = "Bonjour, " +name +"!";

            } else if (language == "Romanian")
            {
                greeting = "Buna, " + name + "!";

            } else if (language == "Spanish")
            {
                greeting = "Hola, " + name + "!";
            }
            else if (language == "Italian")
            {
                greeting = "Ciao, " + name + "!";
            }
            else if (language == "Hindi")
                {
                greeting = "Namaskaar, " + name + "!";
            }
            else
            {
                greeting = "Hello, " + name;
            }
            return Content(string.Format("<h1>{0}</h1>",greeting), "text/html");
        }

        [Route("/Hello")]
        [HttpPost]
        public IActionResult Display(string name, string language )
        {
            return CreateMessage(name,language);
        }
       


        [Route("/Hello/{name}")]
       public IActionResult Index2(string name)
        {
            return Content(string.Format("<h1>Hello {0}</h1>", name), "text/html");
            
        }
        

        public IActionResult Goodbye()
        {
        return Content("Goodbye");
    }
    }
}
