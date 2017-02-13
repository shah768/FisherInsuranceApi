using System;
using Microsoft.AspNetCore.Mvc;

[Route("claim")]
public class CustomerCareController : Controller

{       
    

    [Route("fileclaim")]
    public IActionResult NewClaim()
    {
        return Ok("This page will be to file claims for CustomerCareController");
    }

    [Route("myclaims")]
    public IActionResult ClaimHistory()
    {
        return Ok("This page will be used to check status from CustomerCareController");
    }

}