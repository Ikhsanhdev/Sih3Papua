using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sih3Papua.Models;

namespace Sih3Papua.Controllers;

public class H3Controller : Controller
{
    private readonly ILogger<H3Controller> _logger;

    public H3Controller(ILogger<H3Controller> logger)
    {
        _logger = logger;
    }

    public IActionResult Hidrologi()
    {
        return View();
    }

    public IActionResult Hidrogeologi()
    {
        return View();
    }
    public IActionResult Hidrometeorologi()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
