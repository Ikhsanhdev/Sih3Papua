using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Sih3Papua.Models;
// using Sih3Papua.ViewModels;
using Sih3Papua.Interfaces;
// using Sih3Papua.Models.Datatables;
using Serilog;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace Sih3Papua.Controllers;

[Authorize]

public class AdminController : Controller
{
    private readonly ILogger<AdminController> _logger;
    private readonly IUnitOfWorkRepository _unitOfWorkRepository;
    private readonly IUnitOfWorkService _unitOfWorkService;

    public AdminController(IUnitOfWorkRepository unitOfWorkRepository, IUnitOfWorkService unitOfWorkService)
    {
        this._unitOfWorkRepository = unitOfWorkRepository;
        this._unitOfWorkService = unitOfWorkService;
    }

    public IActionResult Index()
    {
        return View();
    }
}