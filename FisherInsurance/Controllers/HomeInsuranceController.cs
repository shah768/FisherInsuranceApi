using System;
using Microsoft.AspNetCore.Mvc;

public class HomeInsuranceController : Controller

{
    public IActionResult Index()
    {
    //return Ok("This is the index of the HomeInsuranceController");
    return View();
    }

    public IActionResult Quote()
    {
   // return Ok("This is the quote of the HomeInsuranceController");
   return View();
    }

}