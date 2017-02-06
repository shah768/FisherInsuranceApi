[Route ("api/cliams/quotes")]

public class ClaimsController : Controller
{


}

//POST api/claims/quotes
[HttpPost]
public IActionResult Post([FromBody]string value)
{
    return Creater(" ", value);
}

// GET api/claims/quotes/5
[HttpGet("{id}")]
public IActionResult Get(int id)
{
return Ok("The id is: " + id);
}
// PUT api/claims/quotes/id
[HttpPut("{id}")]
public IActionResult Put(int id, [FromBody]string value)
{
return NoContent();
}
// DELETE api/claims/quotes/id
[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
return Delete(id);
}