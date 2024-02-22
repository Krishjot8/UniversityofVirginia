using UniversityofVirginia.Models;

namespace UniversityofVirginia.Repositories
{
    public interface ITeacherRepository
    {

        Task<List<Teachers>> GetTeachersAsync();

        Task<Teachers> GetTeacherByIdAsync(int id);

        Task<Teachers> AddTeacherAsync(Teachers teachers);

        Task<Teachers> UpdateTeacherAsync(Teachers teachers);

        Task<Teachers> DeleteTeacherAsync(int id);

    }
}
