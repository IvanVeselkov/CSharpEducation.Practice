using System;

namespace Practice3.Task9
{
    internal class Student
    {
        private string nameStudent;

        public string NameStudent
        {
            get => nameStudent;
            set { nameStudent = value; }
        }

        private int ageStudent;

        public int AgeStudent
        {
            get => ageStudent;
            set { ageStudent = value; }
        }

        public Student(string name = "Неизветсно", int age = 0)
        {
            nameStudent = name;
            ageStudent = age;
        }
    }
}