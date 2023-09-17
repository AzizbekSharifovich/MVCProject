using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;

namespace MVCProject.Controllers;

public class RegistrationController : Controller
{
    public RegistrationController()
    {
        
    }
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    public IActionResult Register([FromForm] RegisterViewModel model)
    {
        return View(model);
    }
}
