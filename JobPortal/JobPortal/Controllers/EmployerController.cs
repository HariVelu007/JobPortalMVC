﻿using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
    public class EmployerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
