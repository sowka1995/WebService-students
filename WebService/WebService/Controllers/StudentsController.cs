using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using WebService.Models;
using WebService.Models.DTOs;
using WebService.Repository;

namespace WebService.Controllers
{
    public class StudentsController : ApiController
    {
        private IStudentsRepository studentsRepository;

        public StudentsController(IStudentsRepository studentsRepository)
        {
            this.studentsRepository = studentsRepository;
        }

        // GET: api/Students/GetStudents
        [HttpGet]
        public async Task<ICollection<StudentDTO>> GetStudents()
        {
            return await studentsRepository.GetAllAsync();
        }

        // GET api/Students/GetStudent/2
        [HttpGet]
        public async Task<IHttpActionResult> GetStudent(int id)
        {
            var student = await studentsRepository.GetAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }

        // POST: api/Students/AddStudent
        [HttpPost]
        public async Task<IHttpActionResult> AddStudent([FromBody] Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var addedStudent = await studentsRepository.AddAsync(student);

            return Ok(addedStudent);
        }
    }
}