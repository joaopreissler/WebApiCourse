using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICourse.Data;

using Microsoft.AspNetCore.Authorization;
using WebAPICourse.Entities;
using WebAPICourse.Interfaces;
using WebAPICourse.DTOs;

namespace WebAPICourse.Controllers
{
    public class BuggyController : BaseApiController
    {
        private readonly DataContext _context;
        private readonly ITest _test;
        public BuggyController(DataContext context, ITest test)
        {
            _context = context;
            _test = test;
        }
        [Authorize]
        [HttpGet("auth")]
        public ActionResult<string> GetSecret()
        {
            return "secret text";
        }
        [HttpGet("not-found")]
        public ActionResult<AppUser> GetNotFound()
        {
            var thing = _context.Users.Find(-1);
            if (thing == null) return NotFound();

            return Ok(thing);
        }
        [HttpGet("server-error")]
        public ActionResult<string> GetServerError()
        {

            var thing = _context.Users.Find(-1);
            string thingtoReturn = thing.ToString();
            return thingtoReturn;
        }
        [HttpGet("bad-request")]
        public ActionResult<string> GetBadRequest()
        {
            return BadRequest("This was not a good Request");
        }
        [HttpGet("test/{Id}")]
        public async Task<MemberDto> Test(int Id)
        {
            return await _test.GetUser(Id);
        }
    }
}
