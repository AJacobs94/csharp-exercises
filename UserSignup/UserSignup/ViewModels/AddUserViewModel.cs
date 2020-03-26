using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UserSignup.Models;

namespace UserSignup.ViewModels
{
    public class AddUserViewModel 
    {
        [Required]
        [MinLength(6, ErrorMessage="User name must be 6 characters long.")]
        [StringLength(15, ErrorMessage ="User name must be less than 15 characters.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage ="Must contain only letters.")]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(6)]
        // [MinLength(6, ErrorMessage="Password must be atleast 6 characters")]
        [Compare(nameof(Confirm),ErrorMessage ="Passwords do not match.")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Verify Password")]
        public string Confirm { get; set; }
        public int UserId { get; }
        public static int nextId = 0;
        public List<User> Users { get; set; }

    }
}
