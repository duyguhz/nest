using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nest.DAL;
using nest.Models;
using nest.ViewModels;

namespace nest.Controllers;

public class HomeController : Controller
{
    private NestContext _context { get; }

    public HomeController(NestContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        HomeVM home = new HomeVM
        {
            Sliders = _context.Sliders.OrderBy(s => s.Order),
           Categories=_context.Categories.Include(p=>p.Products).Where(p=>!p.IsDeleted)

        };
        return View(home);
    }


}

