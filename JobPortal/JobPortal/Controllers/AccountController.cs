using AutoMapper;
using DomainModel;
using JobPortal.Models.Account;
using Microsoft.AspNetCore.Mvc;
using PoratlServices.Interfaces;

namespace JobPortal.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;
        public AccountController(IAccountService service,IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _accountService = service;
            _webHostEnvironment = webHostEnvironment;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel loginView)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpGet]
        public IActionResult UserRegisteration()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EmployerRegisteration()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EmployerRegisteration(EmployerRegViewModel viewModel,IFormFile fuLogo)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Employer emp = _mapper.Map<Employer>(viewModel);
            (bool Result,int EmpID)= await _accountService.RegisterEmployer(emp);
            if(fuLogo!= null)
            {
                var uploadImg = Path.Combine(_webHostEnvironment.WebRootPath, "EmpImages", EmpID.ToString(), fuLogo.FileName);
                using (var stream = new FileStream(uploadImg, FileMode.Create))
                {
                    await fuLogo.CopyToAsync(stream);
                }
                await _accountService.UpdateProfile(uploadImg, EmpID, true);

            }
            TempData["StatusMessage"] = "Employer registered successfully";
            return RedirectToAction("Login");
        }
    }
}
