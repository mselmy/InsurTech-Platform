
using insurtech.Companies;
using insurtech.Users;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insurtech.Controllers
{
    [Route("api/[controller]/[action]")]
    public class EmailController : insurtechControllerBase
    {
        private readonly IUserAppService _userAppService;
        public EmailController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpGet("{id}/{code}")]
        public IActionResult Verify(long id, string code)
        {
            if (code == null || id == 0)
            {
                return BadRequest();
            }

            var result = _userAppService.VerifyEmail(id, code);
            return Ok();
        }






    }
}
