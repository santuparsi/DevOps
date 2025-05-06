using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnDockertoConnectSQL.Models;
namespace HandsOnDockertoConnectSQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public IActionResult Get()
        {
            testContext db = new testContext();
            return Ok(db.Emp);
        }
    }
}
