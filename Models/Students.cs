namespace UniversityofVirginia.Models
{
    public class Students : BaseModel
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public string Email { get; set; }

        public int Mobile { get; set; }

        public DateTime DateofBirth { get; set; }

        public string ProfileImageUrl { get; set; }



    }
}
