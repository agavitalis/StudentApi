﻿using System;
using System.Collections.Generic;

namespace StudentAPI.Models
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
       // public List<Student> Students { get; set; }
    }
}
