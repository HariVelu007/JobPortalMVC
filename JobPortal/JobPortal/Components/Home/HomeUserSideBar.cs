using AutoMapper;
using JobPortal.Models.Home;
using Microsoft.AspNetCore.Mvc;
using PoratlServices.Interfaces;
using System.Security.Claims;

namespace JobPortal.Components.Home
{
    [ViewComponent]
    public class HomeUserSideBar : ViewComponent
    {
        private readonly IAccountService _service;
        private readonly IHttpContextAccessor _httpContext;
        private readonly IMapper _mapper;
        private string Email => _httpContext.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
        public HomeUserSideBar(IAccountService service, IHttpContextAccessor httpContext, IMapper mapper)
        {
            _service = service;
            _httpContext = httpContext;
            _mapper = mapper;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            DomainModel.JobSeeker seeker = await _service.GetUserBasicInfo(Email);
            seeker.Profile = seeker.Profile ?? "~/img/man.png";
            HUserSideBarViewModel viewModel = _mapper.Map<HUserSideBarViewModel>(seeker);
            return View(viewModel);
        }
    }
}
