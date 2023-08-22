using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;


namespace ST10084788_PROG7311_POE.Controllers
{
    public class FarmersController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public FarmersController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewFarmers()
        {
            // displays all users from NetUsers table that have the user role of "Farmer" assigned to them
            var farmers = _userManager.GetUsersInRoleAsync("Farmer").Result;
            return View(farmers);
        }
    }
}
