class Manager : Employee
{
  private decimal bonus;

  public Manager(string name, decimal salary, decimal bonus, ILogger logger) : base(name, salary, logger)
  {
    this.bonus = bonus;
  }
  public override decimal GetTotalCompensation()
  {
    return bonus;
  }

  public void DisplayManagementDetails()
  {
    DisplayInfo();
    Console.WriteLine($"Manager's Bonus: {bonus:C}");
  }

}