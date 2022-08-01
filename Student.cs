using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Student : Person
    {
        private static int _id;
        public int Id { get; }
        public string[] Lessons { get; set; } = new string[0];

        public Student()
        {
            _id++;
            Id = _id;
        }
    }
}