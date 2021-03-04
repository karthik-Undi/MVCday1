using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mar4MVC
{
    public class Student
    {
        public Student()
        {

        }
        public int Id { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }

        public Student(int id,String name,int age)

        {
            Id = id;
            Name = name;
            Age = age;
        }
    }
}