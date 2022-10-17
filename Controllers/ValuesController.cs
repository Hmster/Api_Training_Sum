using Api_training1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_training1.Controllers
{
    [Route("api/values")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly NumbersHolder _holder;

        public ValuesController(NumbersHolder holder)
        {
            _holder = holder;
        }

        [HttpPost("add")]
        public IActionResult Add([FromQuery] int number1, [FromQuery] int number2)
        {
            _holder.Add(number1, number2);
            return Ok();
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            return Ok(_holder.Get());
        }

    }
}
