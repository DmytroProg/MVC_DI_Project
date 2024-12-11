using MVC_DI_Project.Models;

namespace MVC_DI_Project.Data;

public interface IDatabase
{
    List<Computer> GetAll();
    void Add(Computer computer);
    void Delete(Computer computer);
    void Update(int id, Computer computer);
}
