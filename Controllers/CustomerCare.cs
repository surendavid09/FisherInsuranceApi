using Microsoft.AspNetCore.Mvc;

[Route("api/customer")]
    public class ClaimsController : Controller
    {
        // Post api/customer/claimstatus
            [Route("claimstatus")]
            [HttpPost]
            public IActionResult Post([FromBody]string value)
            {
                return Created("", value);
            }
        // GET api/customer/claimstatus/5
            [Route("claimstatus")]
            [HttpGet("{id}")]

            public IActionResult Get(int id)
            {
                return Ok("The id is: " + id);
            }

             // PUT api/customer/claimstatus/id
            [Route("claimstatus")]
            [HttpPut("{id}")]

            public IActionResult Put(int id, [FromBody]string value)
            {
                return NoContent();
            }

        // DELETE api/customer/claimstatus/id
            [Route("claimstatus")]
            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                return Delete(id);
            }
        
    }

