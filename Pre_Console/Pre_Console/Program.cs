using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = StudentService.GetStudent();

        }
    }
}
