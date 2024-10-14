using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class StudentLibrary
    {
        public class Student
        {            public string Name { get; set; }
            public int Age { get; set; }
            public string Major { get; set; }
            public Student(string name, int age, string major)
            {
                Name = name;
                Age = age;
                Major = major;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Age: {Age}");
                Console.WriteLine($"Major: {Major}");
            }
            public bool IsAdult()
            {
                return Age >= 18;
            }
        }
    }
}
