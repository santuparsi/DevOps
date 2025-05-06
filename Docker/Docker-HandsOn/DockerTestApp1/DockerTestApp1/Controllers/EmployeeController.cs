using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DockerTestApp1.Models;
namespace DockerTestApp1.Controllers
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
