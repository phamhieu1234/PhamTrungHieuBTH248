using System.ComponentModel.Design;
using System;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanh2003.Models;

namespace BaiThucHanh2003.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee std)
        {
            string ketqua = std.EmployeeName +"-" + std.PhoneNumber;
            ViewBag.message = ketqua;
            return View();
        }
    }
}