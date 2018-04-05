using AutoMapper;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using WebService.Models;
using WebService.Models.DTOs;

namespace WebService.Repository
{
    public class StudentsRepository : IStudentsRepository
    {
        public async Task<ICollection<StudentDTO>> GetAllAsync()
        {
            using (var db = new StudentContext())
            {
                var students = await db.Students.ToListAsync();

                return Mapper.Map<ICollection<Student>, ICollection<StudentDTO>>(students);
            }
        }

        public async Task<StudentDTO> GetAsync(int id)
        {
            using (var db = new StudentContext())
            {
                var student = await db.Students.FindAsync(id);

                return Mapper.Map<Student, StudentDTO>(student);
            }
        }

        public async Task<StudentDTO> AddAsync(Student student)
        {
            using (var db = new StudentContext())
            {
                var addedStudent = db.Students.Add(student);
                await db.SaveChangesAsync();

                return Mapper.Map<Student, StudentDTO>(student);
            }
        }
    }
}