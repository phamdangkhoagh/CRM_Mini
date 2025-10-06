
namespace CRM_Mini.Controllers
{
    using CRM_Mini.Models;
    using CRM_Mini.Models.ViewModels;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;

    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = await _signInManager.PasswordSignInAsync(
                model.Email,
                model.Password,
                model.RememberMe,
                lockoutOnFailure: false
            );

            if (result.Succeeded)
            {
                return Redirect(returnUrl ?? Url.Action("Index", "Home"));
            }

            ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            return View(model);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            //await _signInManager.SignOutAsync();
            //HttpContext.Session.Clear();
            //return RedirectToAction("Index", "Home");

            // Delete Cookies
            await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);

            // Clear the session
            HttpContext.Session.Clear();

            // Prevent caching
            Response.Headers.CacheControl = "no-cache, no-store, must-revalidate";
            Response.Headers.Pragma = "no-cache";
            Response.Headers.Expires = "0";

            return RedirectToAction("Login", "Account");
        }
    }
}