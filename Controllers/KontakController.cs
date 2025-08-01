using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sih3Papua.Models;

namespace Sih3Papua.Controllers;

public class KontakController : Controller
{
    private readonly ILogger<KontakController> _logger;

    public KontakController(ILogger<KontakController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
