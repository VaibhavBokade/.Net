using System;
using System.Collections.Generic;

namespace student_crud.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string? Name { get; set; }
        public string? Course { get; set; }
    }
}
