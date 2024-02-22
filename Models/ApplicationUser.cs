namespace UniversityofVirginia.Models
{
    public class ApplicationUser : BaseModel
    {
        public string UserName { get; set; }

        public string PasswordHash { get; set; }

    }
}
