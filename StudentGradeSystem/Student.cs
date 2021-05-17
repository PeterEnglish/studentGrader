using System;
using System.Collections.Generic;
using System.Text;

namespace StudentGradeSystem
{
    class Student
    {
        private float grade;
        private string name;
        private int age;
        public Student(float grade, string name, int age )
        {
            this.Grade = grade;
            this.Name = name;
            this.Age = age;
        }

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public float Grade { get => grade; set => grade = value; }
    }
}
