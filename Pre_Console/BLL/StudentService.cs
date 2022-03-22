using BLL.Entities;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentService
    {
        public static List<StudentModel> GetStudent() {
            var students = StudentRepo.GetAll();
            //use auto mapper
            var converted = new List<StudentModel>(); //converted data to business model
            return converted;

        }
    }
}
