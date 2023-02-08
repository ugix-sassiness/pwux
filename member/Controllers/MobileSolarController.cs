﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using member.Models;

namespace member.Controllers;

public class MobileSolarController : Controller
{
    private readonly ILogger<MobileSolarController> _logger;

    public MobileSolarController(ILogger<MobileSolarController> logger)
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

