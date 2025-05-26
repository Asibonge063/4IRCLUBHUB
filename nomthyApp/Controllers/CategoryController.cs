using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using nomthyApp.Models;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using nomthyApp.Data;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _context;
    private static readonly List<Category> _categories = new List<Category>
    {
        new Category
        {
            Id = 1,
            Name = "Junior",
            Description = "Entry-level members",
            IconPath = "/images/junior-icon.png"
        },
        new Category
        {
            Id = 2,
            Name = "Junior Senior",
            Description = "Intermediate members",
            IconPath = "/images/junior-senior-icon.png"
        },
        new Category
        {
            Id = 3,
            Name = "Main Senior",
            Description = "Advanced members",
            IconPath = "/images/main-senior-icon.png"
        },
        new Category
        {
            Id = 4,
            Name = "Head",
            Description = "Leadership members",
            IconPath = "/images/head-icon.png"
        }
    };

    public CategoryController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(_categories);
    }

    public IActionResult Details(int id)
    {
        var category = _categories.FirstOrDefault(c => c.Id == id);
        if (category == null)
        {
            return NotFound();
        }
        return View(category);
    } 
}


