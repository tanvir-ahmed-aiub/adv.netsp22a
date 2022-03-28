﻿using BLL.Entities;
using DAL;
using DAL.Database;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentService
    {
        public static bool AuthenticateStudent(string uname, string pass) { 
            var  rt = DataAccessFactory.AuthAccess().Authenticate(uname, pass);
            return rt;
        }
        public static StudentModel Get(int id) {
            var st = DataAccessFactory.StudentDataAccess().Get(id);
            var s = new StudentModel() { 
                Id = st.Id,
                Name = st.Name,
                DeptId = st.DeptId
            };
            return s;
        }
    }
}
