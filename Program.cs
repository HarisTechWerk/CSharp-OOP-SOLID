class Program
{
  static void Main()
  {

    ILogger logger = new ConsoleLogger(); // Create Logger one time

    Employee emp1 = new Manager("Haris", 80000, 20000, logger); // Inject Logger
    emp1.DisplayInfo();

    Manager manager = new Manager("John", 100000, 25000, logger); // Inject Logger
    manager.DisplayManagementDetails();
  }
}