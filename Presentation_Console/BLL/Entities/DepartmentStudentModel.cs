using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Entities
{
    class DepartmentStudentModel
    {
        //inheritance
        List<StudentModel> students;
        public DepartmentStudentModel()
        {

            students = new List<StudentModel>();
        }
    }
}
