using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Project05_MVCTemelleri.Models;

namespace Project05_MVCTemelleri.Controllers;
//controllerlar isimlendirilirken mutlaka controller ifadesi ile bitmek zorundadır. 
public class HomeController : Controller
{
   

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About(){
        return View();
    }
}