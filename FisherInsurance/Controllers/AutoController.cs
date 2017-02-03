using Microsoft.AspNetCore.Mvc;

public class AutoController : Controller

{
    public IActionResult Index()
    {
    return Ok("This is the index of the AutoController");
    }
}