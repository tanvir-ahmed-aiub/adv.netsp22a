using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentRepo
    {
        public static List<Student> GetAll() {
            UMS_Sp22_AEntities db = new UMS_Sp22_AEntities();
            return db.Students.ToList();
        }
    }
}
