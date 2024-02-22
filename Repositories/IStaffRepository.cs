using UniversityofVirginia.Models;

namespace UniversityofVirginia.Repositories
{
    public interface IStaffRepository
    {

        Task<List<Staff>> GetStaffAsync();

        Task<Staff> GetStaffByIdAsync(int id);

        Task<Staff> AddStaffAsync(Staff staff);

        Task<Staff> UpdateStaffAsync(Staff staff);

        Task<Staff> DeleteStaffAsync(int id);

    }
}
