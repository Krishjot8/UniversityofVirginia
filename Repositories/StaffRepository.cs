using Microsoft.EntityFrameworkCore;
using UniversityofVirginia.Context;
using UniversityofVirginia.Models;

namespace UniversityofVirginia.Repositories
{
    public class StaffRepository : IStaffRepository
    {

        private readonly UniversityContext _context;

        public StaffRepository(UniversityContext context)
        {
            _context = context;
        }



        public async Task<List<Staff>> GetStaffAsync()
        {
            return await _context.Staff.ToListAsync();
        }


        public async Task<Staff> GetStaffByIdAsync(int id)
        {
            return await _context.Staff.FindAsync(id);
        }

        public async Task<Staff> AddStaffAsync(Staff staff)
        {
            _context.Staff.Add(staff);

            await _context.SaveChangesAsync();

            return staff;
        }

        public async Task<Staff> UpdateStaffAsync(Staff staff)
        {
            var existingstaff = await _context.Staff.FindAsync(staff.Id);

            if (existingstaff == null) {


                return null;
            }


            existingstaff.FirstName = staff.FirstName;
            existingstaff.LastName = staff.LastName;
            existingstaff.Position = staff.Position;
            existingstaff.Email = staff.Email;
            existingstaff.Mobile = staff.Mobile;
            existingstaff.DateofBirth = staff.DateofBirth;
            existingstaff.ProfileImageUrl = staff.ProfileImageUrl;
           



            await _context.SaveChangesAsync();

            return existingstaff;


        }

        public async Task<Staff> DeleteStaffAsync(int id)
        {
            var stafftodelete = await _context.Staff.FindAsync(id);

            if (stafftodelete != null) {

                _context.Staff.Remove(stafftodelete);

                await _context.SaveChangesAsync();
            
            }

            return stafftodelete;
            }
        }





    }
