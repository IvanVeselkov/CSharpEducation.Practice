using System;

namespace Practice3.Task2
{
    internal class Student
    {
        private string studentName;
        private int studentAge;
        private int studentAverageScore = 5;

        public int StudentAverageScore
        {
            get => studentAverageScore;
            set
            {
                if ((value >= 0) && (value < 6))
                {
                    studentAverageScore = value;
                }
            }
        }

        public Student(string name, int age)
        {
            studentName = name;
            studentAge = age;
            studentAverageScore = 5;
        }

        public void OutputOfInformationAboutTheStudent()
        {
            Console.WriteLine(string.Format(" Имя студента: {0} \n Возраст студента: {1}", studentName, studentAge));
        }
    }
}