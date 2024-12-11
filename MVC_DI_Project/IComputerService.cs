using MVC_DI_Project.Models;

namespace MVC_DI_Project;

public interface IComputerService
{
    List<Computer> GetComputers();
    void AddComputer(Computer computer);
    void RemoveComputer(Computer computer);
    void UpdateComputer(int id, Computer computer);
}
