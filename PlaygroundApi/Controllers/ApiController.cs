namespace PlaygroundApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ApiController<TController> : ControllerBase
    where TController : ApiController<TController>
{
}
