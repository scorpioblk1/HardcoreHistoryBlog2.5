﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using HardcoreHistoryBlog.Data;

namespace HardcoreHistoryBlog.Controllers
{
    public class AccountController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Me()
        {
            return View();
        }

    }
}