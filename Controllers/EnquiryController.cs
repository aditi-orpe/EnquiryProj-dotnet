using Microsoft.AspNetCore.Mvc;

namespace Enquiryproj_dotnet.Controllers;

[ApiController]
[Route("[controller]")]
public class EnquiryController : ControllerBase
{
    
    private readonly ILogger<EnquiryController> _logger;

    public EnquiryController(ILogger<EnquiryController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Save()
    {
        return "Hello Enquiry";
    }


    [HttpPost(Name = "SaveEnquiry")]
    public string Save(Enquiry enquiry)
    {
        return "data saved";
    }
}
