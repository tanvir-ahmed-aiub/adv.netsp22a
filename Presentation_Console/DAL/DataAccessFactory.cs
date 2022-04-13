using DAL.Database;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static UMS_Sp22_AEntities db = new UMS_Sp22_AEntities();
        public static IRepository<Student,int> StudentDataAccess() {
            return new StudentRepo(db);
        }
        public static IRepository<Department,int> DeptDataAccess() {
            return new DepartmentRepo(db);
        }
        public static IAuth<bool> AuthAccess() {
            return new StudentRepo(db);
        }
        public static IAuth<Token> AuthDataAccess() {
            return new TokenRepo(db);
        }
        public static IRepository<Token, string> TokenDataAccess() {
            return new TokenRepo(db);
        }
    }
}
