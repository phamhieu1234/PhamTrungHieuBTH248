using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanh0703.Models;

namespace BaiThucHanh0703.Controllers;

public class StudentController : Controller
{
public IActionResult Index()
    {
        return View();
    }
   [HttpPost]
    public IActionResult Index(string FullName)
    {
        string strReturn = "Hello" + " " + FullName;
        ViewBag.abc = strReturn;
        return View();
    }

     public IActionResult Create()
    {
        return View();
    }
    
}
