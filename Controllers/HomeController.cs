using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers;

public class HomeController : Controller {


    [Route("/")]
    public IActionResult Index() {
        return View("/Views/Index.cshtml");
    }
}