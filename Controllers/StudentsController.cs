using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UniversityofVirginia.Models;
using UniversityofVirginia.Repositories;

namespace UniversityofVirginia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentsController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Students>>> GetAllStudents() {

            try

            {
                var students = await _studentRepository.GetStudentsAsync();

                return Ok(students);
            }

            catch
            {

                return StatusCode(500,"Internal Server Error");
            
            }
        
        
        
        }
        
        
    }
}
