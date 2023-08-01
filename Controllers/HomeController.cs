using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RegistrationApp.Models;

namespace RegistrationApp.Controllers;

public class HomeController : Controller
{
    [HttpGet("/")]
    public IActionResult Index()
    {
        return View();
    }
}
