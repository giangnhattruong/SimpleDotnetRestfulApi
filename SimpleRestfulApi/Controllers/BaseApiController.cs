using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace SimpleRestfulApi.Controllers
{
    [Route("/api/v1.0/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
    }
}
