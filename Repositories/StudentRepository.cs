using Microsoft.EntityFrameworkCore;
using UniversityofVirginia.Context;
using UniversityofVirginia.Models;

namespace UniversityofVirginia.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly UniversityContext _context;

        public StudentRepository(UniversityContext context)
        {
            _context = context;
        }



        public async Task<List<Students>> GetStudentsAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Students> GetStudentByIdAsync(int id)
        {
            return await _context.Students.FindAsync(id);
        }




        public async Task<Students> AddStudentAsync(Students student)
        {
            _context.Students.Add(student);

             await _context.SaveChangesAsync();


            return student;
        }

        public async Task<Students> UpdateStudentAsync(Students student)
        {
            var existingStudent = await _context.Students.FindAsync(student.Id);


            if (existingStudent == null) {


                return null;
            }


            existingStudent.FirstName = student.FirstName;
            existingStudent.LastName = student.LastName;
            existingStudent.Email = student.Email;
            existingStudent.Mobile = student.Mobile;
            existingStudent.DateofBirth = student.DateofBirth;
            existingStudent.ProfileImageUrl = student.ProfileImageUrl;




            await _context.SaveChangesAsync();

            return existingStudent;


        }


        public async Task<Students> DeleteStudentAsync(int id)
        {
            var studenttodelete = await _context.Students.FindAsync(id);

            if (studenttodelete != null) {


                _context.Students.Remove(studenttodelete);

                await _context.SaveChangesAsync();
            
            }

            return studenttodelete;
        }

     
       

    
    }
}
