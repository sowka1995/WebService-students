using System.Web.Http;

namespace WebService.Controllers
{
    [RoutePrefix("api/simple")]
    public class SimpleController : ApiController
    {
        [HttpGet]
        [Route("getData/{number}/")]
        public IHttpActionResult GetData(double number)
        {
            var result = number * 2;
            return Ok(result);
        }
    }
}
