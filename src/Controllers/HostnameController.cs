using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace hostname_core.Controllers
{
    [Route("api/[controller]")]
    public class HostnameController : Controller
    {
        // GET api/hostname
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "hostname" };
        }
    }
}
