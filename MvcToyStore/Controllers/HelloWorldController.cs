using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcToyStore.Data;
using MvcToyStore.Models;

namespace MvcToyStore.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        private readonly MvcToyContext _context;
        public HelloWorldController(MvcToyContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return _context.Toy != null ?
                          View(await _context.Toy.ToListAsync()) :
                          Problem("Entity set 'MvcToyContext.Toy'  is null.");
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}