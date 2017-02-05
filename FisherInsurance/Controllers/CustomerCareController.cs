using Microsoft.AspNetCore.Mvc;

[Route("customer")]

public class CustomerCareController : Controller

{       
    public IActionResult Index()
    {
    return Ok("This is the index of the CustomerCareController");
    }
     public IActionResult Claim()
    {
    return Ok("This is the claims of the CustomerCareController");
    }
[Route("fileclaim")]
  public IActionResult NewClaim()
    {
    return Ok("This page will be to file claims for CustomerCareController");
    }
[Route("claimstatus")]
public IActionResult ClaimHistory()
    {
    return Ok("This page will be used to check status from CustomerCareController");
    }

}