using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using member.Models;

namespace member.Controllers;

public class SolarController : Controller
{
    private readonly ILogger<SolarController> _logger;

    public SolarController(ILogger<SolarController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Messages()
    {
        return View();
    }

    public IActionResult NewServiceAddress()
    {
        return View();
    }

    public IActionResult ReferAFriend()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

