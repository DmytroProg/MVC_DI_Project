using MVC_DI_Project.Data;
using MVC_DI_Project.Models;

namespace MVC_DI_Project;

public class ComputerService : IComputerService
{
    private readonly IDatabase _computerDatabase;

    public ComputerService(IDatabase computerDatabase)
    {
        _computerDatabase = computerDatabase;
    }

    public void AddComputer(Computer computer)
    {
        
    }

    public List<Computer> GetComputers()
    {
        return _computerDatabase.GetAll();
    }

    public void RemoveComputer(Computer computer)
    {
        
    }

    public void UpdateComputer(int id, Computer computer)
    {
        
    }
}
