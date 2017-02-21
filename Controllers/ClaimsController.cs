using FisherInsuranceApi.Data;
using FisherInsuranceApi.Models;
using Microsoft.AspNetCore.Mvc;
[Route ("api/claims")]

public class ClaimsController : Controller
{
    
    //POST api/claims
    [HttpPost]
    public IActionResult Post([FromBody] Claim claim)
    {
        return Ok(db.CreateClaim(claim));
    }

  
    // GET api/claims/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
    return Ok("The id is: " + id);
    }

    // PUT api/claims/id
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody]string value)
    {
    return NoContent();
    }

    // DELETE api/claims/id
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
    return Delete(id);
     }
     private IMemoryStore db;
    public ClaimsController(IMemoryStore repo)
    {
        db = repo;
    }
      [HttpGet]
    public IActionResult GetClaim()
    {
         return Ok(db.RetrieveAllClaims);
     }
}