using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;


namespace ST10084788_PROG7311_POE.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager<IdentityRole> _roleManager;
       
        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender,
            RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required]
            [Display(Name = "Full Name")]
            [StringLength(70, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            public string FullName { get; set; }

            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();


            if (ModelState.IsValid)
            {

                var password = Input.Password;

                // Check if the password meets the criteria
                if (!IsPasswordValid(password, out var errorMessage))
                {
                    ModelState.AddModelError(string.Empty, errorMessage);
                    return Page();
                }

                var existingUser = await _userManager.FindByEmailAsync(Input.Email);
                if (existingUser != null)
                {
                    ModelState.AddModelError(string.Empty, "This email is already registered.");
                    return Page();
                }

                // get full name and save it to NetUsers table
                string fullNameSpacesRemoved = Input.FullName.Replace(" ", "");
                var user = new IdentityUser { UserName = fullNameSpacesRemoved, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);


                // assign a user role to the user
                var roleExists = await _roleManager.RoleExistsAsync("Employee");

                if (!roleExists)
                {
                    var roleResult = await _roleManager.CreateAsync(new IdentityRole("Employee"));
                }

                var role = await _userManager.AddToRoleAsync(user, "Employee");

                if (result.Succeeded & role.Succeeded)
                {
                    // confirm users email
                    var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var confirmResult = await _userManager.ConfirmEmailAsync(user, token);
                    
                    _logger.LogInformation("User created a new account with password.");

                   // await _signInManager.SignInAsync(user, isPersistent: false);
                  
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }


            return Page();

        }

        private bool IsPasswordValid(string password, out string errorMessage)
        {
            // Password validation

            if (password.Length < 8)
            {
                errorMessage = "Password must be at least 8 characters long.";
                return false;
            }

            if (!password.Any(char.IsUpper))
            {
                errorMessage = "Password must contain at least one uppercase letter.";
                return false;
            }

            if (!password.Any(char.IsLower))
            {
                errorMessage = "Password must contain at least one lowercase letter.";
                return false;
            }

            if (!password.Any(char.IsDigit))
            {
                errorMessage = "Password must contain at least one digit.";
                return false;
            }

            if (!password.Any(c => !char.IsLetterOrDigit(c)))
            {
                errorMessage = "Password must contain at least one special character.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }


    }
}
