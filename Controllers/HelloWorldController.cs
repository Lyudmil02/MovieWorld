﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWorld.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "<<<This is my default action......>>>";
        }

        public string Welcome()
        {
            return "<<<This is the Welcome action method......>>>";
        }
    }
}
