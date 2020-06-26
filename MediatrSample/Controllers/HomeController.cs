using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatrSample.Models;
using System.ComponentModel.DataAnnotations;

namespace MediatrSample.Controllers
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/create")]
        public IActionResult CreateCustomer(Customer customer)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // save the customer

            return Ok(customer);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
