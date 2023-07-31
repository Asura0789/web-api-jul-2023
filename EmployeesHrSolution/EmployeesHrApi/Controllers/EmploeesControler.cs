using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace EmployeesHrApi.Controllers
{
    public class EmployeesController : ControllerBase
    {
        [HttpGet("/employees")]
        public async Task<ActionResult> GetEmployeesAsync()

        {
            return Ok("Success meesge");
        }
    }
}

