﻿using BLL.Entities;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentModel s = StudentService.Get(1);
            Console.WriteLine("Name: " + s.Name);
        }
    }
}
