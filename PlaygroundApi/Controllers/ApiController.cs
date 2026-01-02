namespace PlaygroundApi.Controllers;

[Route("[controller]")]
[ApiController]
public class ApiController<TController> : ControllerBase
    where TController : ApiController<TController>
{
}
