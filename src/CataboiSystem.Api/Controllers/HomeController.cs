using CataboiSystem.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace CataboiSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
    [Route("anonymous")]
    [AllowAnonymous]
    public string GetAnonymous() => "Anônimo";

    [HttpGet]
    [Route("authenticated")]
    [Authorize]
    public string GetAuthenticated() => $"Autenticado - {User?.Identity?.Name} ";

    [HttpGet]
    [Route("user")]
    [Authorize(Roles = UserRoles.User)]
    public string GetUser() => "User";

    [HttpGet]
    [Route("admin")]
    [Authorize(Roles = UserRoles.Admin)]
    public string GetAdmin() => "Admin";
    }
}