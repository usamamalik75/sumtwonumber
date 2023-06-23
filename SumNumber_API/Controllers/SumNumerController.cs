using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SumNumber_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SumNumerController : ControllerBase
    {
        [HttpPost]
        public int Add(int num1, int num2) 
        {
            var num = new Numbers();
            return num.Sum(num1, num2);
        }
    }
}
