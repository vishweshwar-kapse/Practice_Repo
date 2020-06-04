using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dummy_Application
{
   public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
    public class Student : Person
    {
        public string SchoolName { get; set; }
    }

    public class Teacher:Student
    {
        public decimal  Salary { get; set; }
    }
}
