using Microsoft.EntityFrameworkCore;
using UniversityofVirginia.Context;
using UniversityofVirginia.Models;

namespace UniversityofVirginia.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly UniversityContext _context;

        public TeacherRepository(UniversityContext context)
        {
            _context = context;
        }

        public async Task<List<Teachers>> GetTeachersAsync()
        {
            return await _context.Teachers.ToListAsync();
        }


        public async Task<Teachers> GetTeacherByIdAsync(int id)
        {
            return await _context.Teachers.FindAsync(id);
        }


        public async Task<Teachers> AddTeacherAsync(Teachers teacher)
        {
            _context.Teachers.Add(teacher);

            await _context.SaveChangesAsync();

            return teacher;
        }

        public async Task<Teachers> UpdateTeacherAsync(Teachers teacher)
        {
            var existingteacher = await _context.Teachers.FindAsync(teacher.Id);

            if (existingteacher == null) {


                return null;
            }

            existingteacher.FirstName = teacher.FirstName;
            existingteacher.LastName = teacher.LastName;
            existingteacher.Email = teacher.Email;
            existingteacher.Mobile = teacher.Mobile;
            existingteacher.DateofBirth = teacher.DateofBirth;
            existingteacher.ProfileImageUrl = teacher.ProfileImageUrl;

            await _context.SaveChangesAsync();

            return existingteacher;

        }

        public async Task<Teachers> DeleteTeacherAsync(int id)
        {
            var teachertodelete = await _context.Teachers.FindAsync(id);

            if (teachertodelete != null) {


                _context.Teachers.Remove(teachertodelete);

                await _context.SaveChangesAsync();
            }

            return  teachertodelete;
        }



    }
}