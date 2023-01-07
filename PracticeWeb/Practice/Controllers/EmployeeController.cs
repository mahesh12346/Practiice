using Microsoft.AspNetCore.Mvc;
using Practice.Data;
using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult AddEmpData()
        {
            
            return View();
        }

        public IActionResult AddingData(EmployeeModel emp)
        {

            _db.Employees.Add(emp);
            _db.SaveChanges();
            return RedirectToAction("GetEmpData");
        }

        public IActionResult GetEmpData()
        {
            var data = _db.Employees.ToList();
            return View(data);
        }

    }
}
