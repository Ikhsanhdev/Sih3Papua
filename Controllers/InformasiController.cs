using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sih3Papua.Models;

namespace Sih3Papua.Controllers;

public class InformasiController : Controller
{
    private readonly ILogger<InformasiController> _logger;

    public InformasiController(ILogger<InformasiController> logger)
    {
        _logger = logger;
    }

    public IActionResult Artikel()
    {
        return View();
    }

    public IActionResult Berita()
    {
        return View();
    }
    public IActionResult Profile()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
