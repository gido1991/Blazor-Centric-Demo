using BlazorDemo.Shared;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactController : ControllerBase
{

    private readonly ILogger<ContactController> _logger;

    public ContactController(ILogger<ContactController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetContacts")]
    public IEnumerable<Contact> Get()
    {
        throw new NotImplementedException();
    }
}