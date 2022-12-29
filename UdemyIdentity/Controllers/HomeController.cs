using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UdemyIdentity.Models;
using UdemyIdentity.ViewModels;

namespace UdemyIdentity.Controllers;

public class HomeController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public HomeController(UserManager<AppUser> userManager)
    {
        _userManager = userManager;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult SignUp()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> SignUp(UserViewModel model)
    {
        if (ModelState.IsValid)
        {
            AppUser user = new AppUser(); 
            user.UserName= model.UserName;
            user.Email= model.Email;
            user.PhoneNumber= model.PhoneNumber;

            IdentityResult result= await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("Login");
            }
            else
            {
                foreach (IdentityError item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }

        }
        return View();
    }
}
