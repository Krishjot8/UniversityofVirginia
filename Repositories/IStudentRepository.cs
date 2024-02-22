using UniversityofVirginia.Models;

namespace UniversityofVirginia.Repositories
{
    public interface IStudentRepository
    {

        Task<List<Students>> GetStudentsAsync();

        Task<Students> GetStudentByIdAsync(int id);

        Task<Students> AddStudentAsync(Students students);

        Task<Students> UpdateStudentAsync(Students students);

        Task<Students> DeleteStudentAsync(int id);

    }
}
