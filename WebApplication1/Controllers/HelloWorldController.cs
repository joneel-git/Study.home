using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Views.Home
{
    [Route("[controller]")]
    public class HelloWorldController : Controller
    {
        //GET??
        /*
        READ retrive a representation of a resource*/
        [HttpGet]
        public IActionResult Submit()
        {
            MyModel model = new MyModel();
            ViewBag.Id = model.Id;
            ViewBag.Title = model.Title;
            ViewBag.Name = model.Description;
            ViewBag.DateTime = DateTime.Now;
            //Viewbag is tool for passing data from a controller to view
            return View();
        }
        //POST??
        /*
        Post is used to create new resources CREATE */
        //PUT??
        /*
        UPDATE Update or CReate a recourse
        */
        //DELETE??
        //PATCH??

    }
}