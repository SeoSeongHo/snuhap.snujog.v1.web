using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using snuhap.snujog.v1.web.Models.Login;

namespace snuhap.snujog.v1.web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SignUpController : Controller
    {
        private readonly LoginContext _context;

        public SignUpController(LoginContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        /*
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
        */
    }
}