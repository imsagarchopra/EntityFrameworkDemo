using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManyToManyRelationshipsWithCodeFirst
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}