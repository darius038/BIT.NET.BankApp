using AutoMapper;
using BIT.NET.BankApp.Data.Repositories;
using BIT.NET.BankApp.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT.NET.BankApp.Web.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private IAccountRepository _accRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;


        public UserController(IAccountRepository repository, IMapper mapper, UserManager<User> user)
        {
            _mapper = mapper;
            _accRepository = repository;
            _userManager = user;
        }

        public async Task<IActionResult> Index()
        {
            User appUser = await _userManager.GetUserAsync(User);

            var accountsList = _accRepository.GetAccounts(appUser.Id);
            return View(accountsList);           
        }
    }
}
