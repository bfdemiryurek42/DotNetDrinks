using DotNetDrinks.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetDrinks.Controllers
{
    public class BrandsControllerOld : Controller
    {
        public IActionResult Index()
        {
            var brands = new List<Brand>();
            brands.Add(new Brand { Id=100, Name= "Canadian Club",YearFounded =1902 });
            brands.Add(new Brand { Id=101, Name= "Molson",YearFounded =1786 });
            brands.Add(new Brand { Id=102, Name= "Glenfiddich",YearFounded =1883 });
            brands.Add(new Brand { Id=103, Name= "JP Wiser",YearFounded =1853 });
            brands.Add(new Brand { Id=104, Name= "Jacsıb Triggs",YearFounded =1993 });


            return View(brands);
        }

        // GET: /Brands/Details
        public IActionResult Details(string name)
        {
            if (name == null)
            {
                return BadRequest();
            }
            ViewBag.name = name;
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
