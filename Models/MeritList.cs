namespace UniversityofVirginia.Models
{
    public class MeritList: BaseModel

    {

        public int Rank { get; set; }

        public string ApplicantName { get; set; }

        public float GPA { get; set; }

        public int SATScore { get; set; }


        public string HighSchool { get; set; }


    }
}
