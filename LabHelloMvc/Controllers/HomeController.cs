using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LabHelloMvc.Models;

namespace LabHelloMvc.Controllers;

public class HomeController : Controller
{
    
    public IActionResult Index()
    {
            // Create Person object
            var person = new Person
            {
                FirstName = "Bob",
                LastName = "Ross"
            };

            
            return View(person);
        }
    }
    