using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public void Showinfo()
        {
            Console.WriteLine("name " + name);
            Console.WriteLine("age " + age);
        }

    }

    class Teacher : Person
    {
        public int sal { get; set; }
    }


    class Student : Person
    {
        public int TotalMark { get; set; }
    }

    internal class Q2
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
        }
    }
}
