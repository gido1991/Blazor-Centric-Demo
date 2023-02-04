using BlazorDemo.Shared;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDemo.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactsController : ControllerBase
{

    private readonly ILogger<ContactsController> _logger;

    public ContactsController(ILogger<ContactsController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet(Name = "GetContacts")]
    public ActionResult Get()
    {
        return Ok(new List<Contact>
        {
            new()
            {
                PostalCode = "1234AB",
                FirstName = "Jan",
                LastName = "Klaas"
            }
        });
    }


    [HttpPut(Name = "CreateContacts")]
    public ActionResult Put(Contact contact)
    {
        return Created(Url.Action(nameof(Get)) ?? string.Empty, contact);
    }
}