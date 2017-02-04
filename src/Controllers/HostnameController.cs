using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace hostname_core.Controllers
{
    [Route("api/[controller]")]
    public class HostnameController : Controller
    {
        // GET api/hostname
        [HttpGet]
        public string Get()
        {
            var hostname = System.Net.Dns.GetHostName();

            return hostname;
        }
    }
}
