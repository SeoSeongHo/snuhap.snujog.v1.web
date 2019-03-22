using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using snuhap.snujog.v1.web.Models.Login;

namespace snuhap.snujog.v1.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginContext _context;

        public LoginController(LoginContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Login>> PostLogin(Login info)
        {
            var isCorrect = _context.Infos.Find(info.Username, info.Password);

            if (isCorrect == null)
            {

            }
            else
            {

            }
        }
    }
}