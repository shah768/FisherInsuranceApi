[Route ("api/life/quotes")]

public class LifeController : Controller
{


}

//POST api/life/claims
[HttpPost]
public IActionResult Post([FromBody]string value)
{
    return Creater(" ", value);
}

// GET api/life/claims/5
[HttpGet("{id}")]
public IActionResult Get(int id)
{
return Ok("The id is: " + id);
}
// PUT api/life/claims/id
[HttpPut("{id}")]
public IActionResult Put(int id, [FromBody]string value)
{
return NoContent();
}
// DELETE api/life/claims/id
[HttpDelete("{id}")]
public IActionResult Delete(int id)
{
return Delete(id);
}