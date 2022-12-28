using Microsoft.AspNetCore.Mvc;
using UdemyIdentity.ViewModels;

namespace UdemyIdentity.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult SignUp()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SignUp(UserViewModel user)
    {
        return View();
    }
}
