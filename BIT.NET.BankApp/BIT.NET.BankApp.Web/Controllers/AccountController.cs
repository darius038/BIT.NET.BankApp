using AutoMapper;
using BIT.NET.BankApp.Data.Repositories;
using BIT.NET.BankApp.Domain.Entities;
using BIT.NET.BankApp.Web.Models.AccountViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BIT.NET.BankApp.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private IAccountRepository _accRepository;

        public AccountController(
            IMapper mapper, 
            UserManager<User> userManager, 
            SignInManager<User> signInManager, 
            IAccountRepository repository)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _accRepository = repository;
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegistrationViewModel registrationModel)
        {
            if (!ModelState.IsValid)
            {
                return View(registrationModel);
            }

            var user = _mapper.Map<User>(registrationModel);
            var result = await _userManager.CreateAsync(user, registrationModel.Password);


            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return View(registrationModel);
            }

            await _userManager.AddToRoleAsync(user, "Customer");
            _accRepository.CreateAccount(user);
            return RedirectToAction(nameof(AccountController.Login), "Account");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginModel, string returnUrl = null)
        {
            if (!ModelState.IsValid)
            {
                return View(loginModel);
            }

            var result = await _signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, false, false);

            if (result.Succeeded)
            {
                return RedirectToLocal(returnUrl);
            }
            else
            {
                ModelState.AddModelError("", "Invalid UserName or Password");
                return View();
            }
        }
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "User");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}

