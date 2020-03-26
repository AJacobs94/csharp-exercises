using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UserSignup.Models
{
    public class User
    {    
  
        public string Name { get; set; }
        public string Email { get; set; }

     
        public string Password { get; set; }

       
        [Display(Name="Verify Password")]
        public string Confirm { get; set; }
        public int UserId{get; }
        public static int nextId = 0;


        public User()
        {
            UserId = nextId;

        }
      
    }
}
