using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    class DepartmentRepo
    {
        public static Department Get(int id) {
            UMS_Sp22_AEntities db = new UMS_Sp22_AEntities();
            return db.Departments.FirstOrDefault(x => x.Id == id);
        }
    }
}
