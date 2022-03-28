using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class StudentRepoV2 : IRepository<Student, int>
    {
        private UMS_Sp22_AEntities db;
        public StudentRepoV2(UMS_Sp22_AEntities db)
        {
            this.db = db;
        }
        public bool Add(Student obj)
        {
            
            throw new NotImplementedException();
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
            //API GET
            throw new NotImplementedException();
        }

        public List<Student> Get()
        {
            throw new NotImplementedException();
        }
    }
}
