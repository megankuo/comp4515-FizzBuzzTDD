using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FizzBuzzWeb.Models;
using FizzBuzzLibrary;

namespace FizzBuzzWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Fizz(int id)
    {
        FizzBuzz fb = new FizzBuzz();
        ViewBag.Output = fb.GetResult(id);
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
