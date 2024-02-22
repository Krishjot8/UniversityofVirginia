namespace UniversityofVirginia.Models
{
    public class Grades: BaseModel
    {


        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public string Assignment { get; set; }

        public int Grade { get; set; }

        public DateTime Date { get; set; }
        


    }
}
