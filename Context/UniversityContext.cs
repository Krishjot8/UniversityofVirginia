using Microsoft.EntityFrameworkCore;
using UniversityofVirginia.Models;

namespace UniversityofVirginia.Context
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Address> Address { get; set; }

        public DbSet<Address> ApplicationUser { get; set; }


        public DbSet<Classrooms> Classrooms { get; set; }
       
        public DbSet<Courses> Courses { get; set; }


        public DbSet<Departments> Departments { get; set; }

        public DbSet<Events> Events { get; set; }

        public DbSet<Genders> Genders { get; set; }

        public DbSet<Grades> Grades { get; set; }

        public DbSet<LibraryResources> LibraryResources { get; set; }
        public DbSet<MeritList> MeritList { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Teachers> Teachers { get; set; }

    }
}
