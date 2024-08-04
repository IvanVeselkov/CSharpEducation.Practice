using System;

namespace Practice3.Task1
{
    internal class Student
    {
        private string studentName;
        private int studentAge;

        public Student(string name, int age)
        {
            studentName = name;
            studentAge = age;
        }

        public void OutputOfInformationAboutTheStudent()
        {
            Console.WriteLine(string.Format(" Имя студента: {0} \n Возраст студента: {1}", studentName, studentAge));
        }
    }
}