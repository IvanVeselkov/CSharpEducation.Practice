using System;
using Practice5.Task2.Logger;

namespace Practice5.Task1
{
  class Program
  {
    static void Main(string[] args)
    {
      ConsoleLogger consoleLogger = new ConsoleLogger();
      FileLogger fileLogger = new FileLogger();
      Employee employee = new Employee("Tom",100);
      Manager manager = new Manager("Sara", 200,4);

      Console.WriteLine(employee.CalculateBonus());

      Console.WriteLine(manager.CalculateBonus());

      Contractor contractor = new Contractor("Tom", 100, 4);

      Console.WriteLine(contractor.Salary + contractor.CalculateBonus());

      consoleLogger.Info("Hello");
      fileLogger.Info("Hello");
    }
  }
}
