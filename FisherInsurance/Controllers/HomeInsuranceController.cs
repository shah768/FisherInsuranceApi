using System;
using Microsoft.AspNetCore.Mvc;
namespace FisherInsurance.Models {

[Route ("Homeinsurance")]
public class HomeInsuranceController : Controller

{
    public IActionResult Index()
    {
    //return Ok("This is the index of the HomeInsuranceController");
    return View();
    }

    public IActionResult Quote()
    {
        Quote quote = new Quote
        {
            Id = 345,
            Product = "HomeInsurance",
            ExpireDate = DateTime.Now.AddDays(45),
            Price = 45.00M
        };
        return View(quote);
    }
}
}