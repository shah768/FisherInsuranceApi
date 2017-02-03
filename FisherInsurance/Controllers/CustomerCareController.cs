using Microsoft.AspNetCore.Mvc;

public class CustomerCareController : Controller

{
    public IActionResult Index()
    {
    return Ok("This is the index of the CustomerCareController");
    }
}