namespace UniversityofVirginia.Models
{
    public class LibraryResources: BaseModel
    {

        public string Title { get; set; }

        public string Author { get; set; }

        public DateTime PublicationDate { get; set; }

        public string Type { get; set; }

        public int ISBN { get; set; }

        public string Publisher { get; set; }

          public string Edition { get; set; }

         public string Description { get; set; }


        public string Location { get; set; }

          public bool Availability { get; set; }

        public string URL { get; set; }


        public string AccessRights { get; set; }




    }
}
