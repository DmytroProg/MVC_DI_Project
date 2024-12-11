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
        ValidateComputer(computer);

        _computerDatabase.Add(computer);
    }

    public List<Computer> GetComputers()
    {
        return _computerDatabase.GetAll();
    }

    public void RemoveComputer(Computer computer)
    {
        if (!ComputerExists(computer.Id))
        {
            throw new ArgumentException();
        }

        _computerDatabase.Delete(computer);
    }

    public void UpdateComputer(int id, Computer computer)
    {
        ValidateComputer(computer);
        if (!ComputerExists(computer.Id))
        {
            throw new ArgumentException();
        }

        _computerDatabase.Update(id, computer);
    }

    private void ValidateComputer(Computer computer)
    {
        if (string.IsNullOrEmpty(computer.OperationSystem))
        {
            throw new ArgumentException();
        }
    }

    private bool ComputerExists(int id)
    {
        return _computerDatabase.GetAll().Any(x => x.Id == id);
    }
}
