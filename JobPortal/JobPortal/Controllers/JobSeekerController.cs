﻿using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
    public class JobSeekerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
