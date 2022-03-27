using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class StudentRepo
    {
        public static Student Get(int id)
        {
            UMS_Sp22_AEntities db = new UMS_Sp22_AEntities();
            /*var st = (from s in db.Students
                      where s.Id == id
                      select s).FirstOrDefault();
            return st;*/
            return db.Students.FirstOrDefault(x => x.Id == id);

        }
        public static List<Student> Get() {
            UMS_Sp22_AEntities db = new UMS_Sp22_AEntities();
            return db.Students.ToList();
        }
        public static bool Add(Student st) {
            UMS_Sp22_AEntities db = new UMS_Sp22_AEntities();
            db.Students.Add(st);
            if (db.SaveChanges() != 0) return true;
            return false;

        }
    }
}
