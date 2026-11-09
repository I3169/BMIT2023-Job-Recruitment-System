using Microsoft.AspNetCore.Mvc;

namespace BMIT2023_As._Job_Recruitment_System.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
