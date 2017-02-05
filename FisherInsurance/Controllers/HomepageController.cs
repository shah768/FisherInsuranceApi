using Microsoft.AspNetCore.Mvc;

public class HomepageController : Controller

{
    public IActionResult Index()
    {
    return Ok("This is the index of the HomepageController");
    }

    public IActionResult Quote()
    {
    return Ok("This is the quote of the HomepageController");
    }

}