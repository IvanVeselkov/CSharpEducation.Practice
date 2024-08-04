using System;

namespace Practice3.Task2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student1 = new Student("Egor", 26);
            student1.OutputOfInformationAboutTheStudent();
            student1.StudentAverageScore = 3;
            Console.WriteLine("Средний балл: " + student1.StudentAverageScore);
        }
    }
}