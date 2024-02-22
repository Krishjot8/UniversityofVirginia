using System.ComponentModel.DataAnnotations;

namespace UniversityofVirginia.Models
{
    public class ApplicationUserCreate
    {

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }



        [Required]
        public string UserName { get; set; }


        [Required]
        [MinLength(7)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

    }
}
