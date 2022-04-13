using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_EF_CF.EF
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CourseStudent>Students { get; set; }
        public Course() {
            Students = new List<CourseStudent>();
        }
    }
}
