using MVC_DI_Project.Models;

namespace MVC_DI_Project;

public class ComputerService : IComputerService
{
    public void AddComputer(Computer computer)
    {
        
    }

    public List<Computer> GetComputers()
    {
        return new List<Computer>()
        {
            new Computer() { Id = 1, Name = "Windows" },
            new Computer() { Id = 2, Name = "MacOS" },
            new Computer() { Id = 3, Name = "Linux" },
        };
    }

    public void RemoveComputer(Computer computer)
    {
        
    }

    public void UpdateComputer(int id, Computer computer)
    {
        
    }
}
