using Microsoft.AspNetCore.Mvc;
using NawalKitchenWeb.Data;
using NawalKitchenWeb.Models;

namespace NawalKitchenWeb.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _db;
    public CategoryController(ApplicationDbContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        IEnumerable<Category> objCategoryList = _db.Categories;
        return View(objCategoryList);
    }
    //GET
    public IActionResult Create()
    {    
        return View();
    }
}

