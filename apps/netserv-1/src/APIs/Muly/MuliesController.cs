using Microsoft.AspNetCore.Mvc;

namespace Netserv1.APIs;

[ApiController()]
public class MuliesController : MuliesControllerBase
{
    public MuliesController(IMuliesService service)
        : base(service) { }
}
