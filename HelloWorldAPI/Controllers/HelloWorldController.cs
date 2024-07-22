using Microsoft.AspNetCore.Mvc;

namespace SimpleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello, World!");
        }

        
        [HttpGet("path/{param}")]
        public IActionResult GetWithPathParam(string param)
        {
            return Ok(new { Message = "Path parameter received", PathParam = param });
        }

        
        [HttpGet("query")]
        public IActionResult GetWithQueryParams([FromQuery] string param)
        {
            return Ok(new { Message = "Query parameters received", QueryParam = param });
        }


        [HttpPost("body")]
        public IActionResult PostWithBodyParams([FromBody] dynamic body)
        {
            return Ok(new { Message = "Body parameters received", BodyParams = body });
        }

        [HttpPost("all/{pathParam}")]
        public IActionResult PostWithAllParams(string pathParam, [FromQuery] string queryParam, [FromBody] dynamic body)
        {
            return Ok(new { Message = "Path, query, and body parameters received", PathParam = pathParam, QueryParam = queryParam, BodyParams = body });
        }
    }
}
