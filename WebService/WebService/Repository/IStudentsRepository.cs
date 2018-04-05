using System.Collections.Generic;
using System.Threading.Tasks;
using WebService.Models;
using WebService.Models.DTOs;

namespace WebService.Repository
{
    public interface IStudentsRepository
    {
        Task<ICollection<StudentDTO>> GetAllAsync();
        Task<StudentDTO> GetAsync(int id);
        Task<StudentDTO> AddAsync(Student student);
    }
}