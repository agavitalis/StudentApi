using Microsoft.EntityFrameworkCore;
using StudentAPI.Data;
using StudentAPI.Interfaces;
using StudentAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentAPIContext _context;

        public StudentRepository(StudentAPIContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            return await _context.Student.Include(x => x.Courses).ToListAsync();
        }

       
    }
}
