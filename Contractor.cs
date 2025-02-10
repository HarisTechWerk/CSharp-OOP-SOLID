class Contractor : IWorkable
{
  private string name;
  private ILogger logger;

  public Contractor(string name, ILogger logger)
  {
    this.name = name;
    this.logger = logger;
  }

  public void Work()
  {
    Console.WriteLine($"{name} (contractor) is working...");
  }
}