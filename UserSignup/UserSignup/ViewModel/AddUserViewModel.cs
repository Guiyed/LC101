using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UserSignup.Models;

namespace UserSignup.ViewModel
{
    public class AddUserViewModel
    {

        [Required]
        [RegularExpression("^[a-zA-Z]{5,15}$", ErrorMessage ="User mut be between 5 and 15 alphabetic characters")]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "You must enter an alphanumeric password")]
        [DataType(DataType.Password)]
        [RegularExpression("^[A-Za-z0-9]{5,20}$",ErrorMessage ="Password must be between 5 and 20 alphanumeric characters")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name = "Verify Password")]
        public string Verify { get; set; }

        public int UserId { get; set; }

        public DateTime Created { get; set; }

        public AddUserViewModel()
        {

        }

        public AddUserViewModel(User user)
        {
            UserName = user.Username;
            Email = user.Email;
            Password = user.Password;
            UserId = user.UserId;
            Created = user.Created;
        }

        public User CreateUser()
        {
            User newUser = new User
            {
            Username = this.UserName,
            Email = this.Email,
            Password = this.Password            
            };

            return newUser;
        }

    }
}
