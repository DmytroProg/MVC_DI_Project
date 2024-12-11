using Microsoft.AspNetCore.Mvc;

namespace MVC_DI_Project.Controllers;

public class ComputerController : Controller
{
    private readonly IComputerService _computerService;

    public ComputerController(IComputerService computerService)
    {
        _computerService = computerService;
    }

    public IActionResult GetComputers()
    {
        var computers = _computerService.GetComputers();
        return View(computers);
    }
}
