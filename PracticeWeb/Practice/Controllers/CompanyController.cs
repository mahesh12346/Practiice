using Microsoft.AspNetCore.Mvc;
using Practice.Data;
using Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CompanyController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult AddCompany( )
        {

            return View();

        }
        public IActionResult AddingDataToCompany(CompanyModel cmp)
        {
            _db.Componies.Add(cmp);
            _db.SaveChanges();
            return RedirectToAction("Get_Company");

        }
        public IActionResult Get_Company()
        {

            var data = _db.Componies.ToList();
            return View(data);

        }




        public IActionResult GetCompanyData()
        {
            var data = _db.Componies.ToList();
            return View(data);
        }


    }
}
