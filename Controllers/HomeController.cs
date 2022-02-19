using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PersonalRecipeDatabase.Models;

namespace PersonalRecipeDatabase.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult ViewRecipes()
    {
        var recipes = new List<Recipe>();        
        using(var context = new RecipeDatabaseContext()){
            recipes = context?.Recipes?.ToList();
        }

        return View(recipes);
    }

        public IActionResult AddRecipe()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
