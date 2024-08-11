using System;
using Practice4.Task3._1.Person;

namespace Practice4.Task3._2.PersonUse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person OlegPerson = new Person("Oleg", 24);
            Person SerGAYPerson = new Person("Sergei", 26);

            OlegPerson.GetPersonInfoInConsole();

            SerGAYPerson.GetPersonInfoInConsole();
        }
    }
}