public abstract class Employee
{
  private string name;
  private decimal salary;
  protected readonly ILogger logger; // Injected Dependency

  public Employee(string name, decimal salary, ILogger logger)
  {
    this.name = name;
    this.salary = salary;
    this.logger = logger;
  }
  public virtual void DisplayInfo()
  {
    Console.WriteLine($"Employee: {name}, Salary: {salary:C}");
  }

  public abstract decimal GetTotalCompensation();
}