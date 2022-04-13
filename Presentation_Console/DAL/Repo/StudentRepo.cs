using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class StudentRepo : IRepository<Student, int>,IAuth<bool>
    {
        private UMS_Sp22_AEntities db;
        public StudentRepo(UMS_Sp22_AEntities db)
        {
            this.db = db;
        }
        public bool Add(Student obj)
        {
            db.Students.Add(obj);
            if (db.SaveChanges() != 0) return true;
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Student obj)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            return db.Students.FirstOrDefault(x => x.Id == id);
        }

        public List<Student> Get()
        {
            return db.Students.ToList();
        }
        public bool Authenticate(string uname, string pass) {
            return true;
        }
    }
}
