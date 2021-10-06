using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MatricNo { get; set; }
        public List<Course> Courses { get; set; }
    }
}
