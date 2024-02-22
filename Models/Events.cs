namespace UniversityofVirginia.Models
{
    public class Events : BaseModel
    {


        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        public string Location { get; set; }

        public string Organizer { get; set; }

        public string ContactInformation { get; set; }


        public string EventType { get; set; }

        public bool RegistrationRequired { get; set; }


        public DateTime? RegistrationDeadline { get; set; }
    }
}
