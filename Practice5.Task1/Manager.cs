namespace Practice5.Task1
{
  class Manager : Employee
  {
    public int TeamSize { get; set; }
    public override double CalculateBonus()
    {
      if (TeamSize > 5)
        return Salary / 4;
      return Salary / 5;
    }
    public Manager(string name, double salary, int teamsize):base(name,salary)
    {
      TeamSize = teamsize;
    }
  }
}
