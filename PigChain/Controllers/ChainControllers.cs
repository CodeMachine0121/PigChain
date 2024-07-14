using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace PigChain.Controllers;

[Route("api/[controller]")]
public class ChainControllers: ControllerBase
{

    [HttpGet("")]
    public async Task<PigApiResponse> GetAll()
    {
        return PigApiResponse.SuccessWithData("Success Chain");
    }
 
}


public class PigApiResponse
{
    public string Message { get; set; }
    public string Status { get; set; }
    public object Data { get; set; }
    
    public static PigApiResponse SuccessWithData(object data) => new PigApiResponse()
    {
        Message = "Success with Data",
        Status = HttpStatusCode.OK.ToString(),
        Data = data
    };
}