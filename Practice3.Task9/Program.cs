using System;

namespace Practice3.Task9
{
    internal class Program
    {
        private static void SetHiddenStudentName(Student s)
        {
            s.NameStudent = "Аноним";
        }

        private static void Main(string[] args)
        {
            Student s = new Student("Егор", 26);
            Console.WriteLine(string.Format("Student name: {0}\nStudent age: {1}", s.NameStudent, s.AgeStudent));
            SetHiddenStudentName(s);
            Console.WriteLine(string.Format("Student name: {0}\nStudent age: {1}", s.NameStudent, s.AgeStudent));
        }
    }
}