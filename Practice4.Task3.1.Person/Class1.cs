using System;

namespace Practice4.Task3._1.Person
{
    public class Person
    {
        private string personName;

        public string PersonName
        { private set { personName = value; } get => personName; }

        private int personAge;

        public int PersonAge
        { private set { personAge = value; } get => personAge; }

        public Person()
        {
            PersonName = "unknown";
            PersonAge = 0;
        }

        public Person(string name, int age)
        {
            PersonName = name;
            PersonAge = age;
        }

        public string PersonInfoCard()
        {
            return string.Format("Person name: {0}\nPerson age: {1}\n ", PersonName, PersonAge);
        }

        public void GetPersonInfoInConsole()
        {
            Console.WriteLine(PersonInfoCard());
        }
    }
}