using Microsoft.AspNetCore.Mvc;
using FisherInsuranceApi.Data;
using System.Collections.Generic;
using FisherInsuranceApi.Models;
using System;

[Route("api/customer")]
    public class ClaimsController : Controller
    {
            private IMemoryStore db;
            public ClaimsController(IMemoryStore repo)
            {
                db = repo;
            }

            [HttpGet]
            public IActionResult GetClaims()
            {
                return Ok(db.RetrieveAllClaims);
            }
        
        // GET api/customer/claimstatus/5
            [Route("claimstatus")]
            [HttpGet("{id}")]

            public IActionResult Get(int id)
            {
                return Ok(db.RetrieveClaim(id));
            }

            // Post api/customer/claimstatus 
            [Route("claimstatus")]
            [HttpPost]
            public IActionResult Post([FromBody]Claim claim)
            {
                return Ok(db.CreateClaim(claim));
            }

             // PUT api/customer/claimstatus/id
            [Route("claimstatus")]
            [HttpPut("{id}")]

            public IActionResult Put(int id, [FromBody]Claim claim)
            {
                return Ok(db.UpdateClaim(claim));
            }

        // DELETE api/customer/claimstatus/id
            [Route("claimstatus")]
            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                db.DeleteClaim(id);
                return Ok();
            }
        
    }

