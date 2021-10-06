using StudentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Interfaces
{
    public interface IStudentRepository
    {
        public Task<IEnumerable<Student>> GetAll();
    }
}
