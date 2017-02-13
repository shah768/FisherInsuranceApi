using System;
using Microsoft.AspNetCore.Mvc;
namespace FisherInsurance.Models{

public class AutoController : Controller

{
    
    public IActionResult Index()
    {
    return View();
    //return Ok("This is the index of the AutoController");
    }
    public IActionResult Quote()
    {
        Quote quote = new Quote
        {
            Id = 345,
            Product = "Auto Insurance",
            ExpireDate = DateTime.Now.AddDays(45),
            Price = 45.00M
        };
        return View(quote);
    }
}
}