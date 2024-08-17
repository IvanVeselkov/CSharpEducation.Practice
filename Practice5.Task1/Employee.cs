namespace Practice5.Task1
{
  internal class Employee
  {
    public string Name { get; set; }
    public double Salary { get; set; }

    public virtual double CalculateBonus()
    {
      return Salary / 10;
    }

    public Employee(string name,double salary)
    {
      Name = name;
      Salary = salary;
    }
  }
}