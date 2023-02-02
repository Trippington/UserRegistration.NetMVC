using LoginAndRegistration.Models;
using LoginAndRegistration.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoginAndRegistration.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessRegistration(UserModel userModel)
        {
            MoreSecurityServices moreSecurityServices = new MoreSecurityServices();

            if (!moreSecurityServices.IsValid(userModel))
            {
                return View("RegistrationFailure", userModel);
            }

            else
            {
                return View("RegistrationSuccess", userModel);
            }

        }
    }
}
