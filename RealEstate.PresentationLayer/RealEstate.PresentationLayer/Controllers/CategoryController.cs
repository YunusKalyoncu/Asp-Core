using Microsoft.AspNetCore.Mvc;
using RealEstate.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryservice;

        public CategoryController(ICategoryService categoryservice)
        {
            _categoryservice = categoryservice;
        }

        public IActionResult Index()
        {
            var values = _categoryservice.TGetList();
            return View(values);
        }
    }
}
