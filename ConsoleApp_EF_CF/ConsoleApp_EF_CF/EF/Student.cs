using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_EF_CF.EF
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department{get;set;}

        public virtual ICollection<CourseStudent> Courses { get; set; }
        public Student() {
            Courses = new List<CourseStudent>();
        }
    }
}
