using System;
using System.Linq;
using ConsoleTables;
using System.Collections.Generic;

namespace StudentGradeSystem
{
    class Program
    {
        


        static void Main(string[] args)
        {


            List<Student> studentList = new List<Student>();
           

            bool loopCondition = true;
            while (loopCondition)
            {
                studentList.Add(EnterStudent());
                loopCondition = LoopToEnterStudents();
//              LoopThroughStudents(studentList);
            }

            ConsoleTable
                .From<Student>(studentList)
                .Configure(o => o.NumberAlignment = Alignment.Right)
                .Write(Format.Alternative);

            Console.WriteLine("The Grade Average Was: {0}", GetGradeAverage(studentList));

        }

        static Student EnterStudent()
        {
            int intStudentAge = 0;
            float floatStudentGrade = 0;
            Console.WriteLine("Please enter student name:");
            string studentName = Console.ReadLine();

            Console.WriteLine("Please enter student age:");
            try
            {
                string studentAge = Console.ReadLine();
                intStudentAge = Int16.Parse(studentAge);
            }
            catch
            {
                Console.WriteLine("Invalid input there buddy!");
            }
            try
            {
                Console.WriteLine("Please enter student grade:");
                string studentGrade = Console.ReadLine();
                floatStudentGrade = float.Parse(studentGrade);
            }
            catch
            {
                Console.WriteLine("Invalid input there buddy!");
            }
   

            Student student = new Student(floatStudentGrade, studentName, intStudentAge);
            return student;
        }

        private static bool LoopToEnterStudents()
        {
            Console.WriteLine("Type Y to continue entering students, and N to stop!");
            string loopConditionString = Console.ReadLine();
            if (loopConditionString == "Y")
            {
                return true;
            }
            else if (loopConditionString == "N")
            {
                return false;
            }
            else
            {
                
                Console.WriteLine("Invalid Input");
                return LoopToEnterStudents();
            }
        }

        private static void LoopThroughStudents(List<Student> studentList)
        {
            foreach (Student student in studentList)
            {
                Console.WriteLine("The students age is: {0}, The students name is: {1}, the students grade is: {2} ", student.Age, student.Name, student.Grade);

            }
        }

        private static float GetGradeAverage(List<Student> studentList)
        {
            float totalOfGrades = 0;
            int numberOfStudents = 0;
            
            foreach (Student student in studentList)
            {
                totalOfGrades += student.Grade;
                numberOfStudents++;
            }
            return totalOfGrades / numberOfStudents;
        }
    }
}
