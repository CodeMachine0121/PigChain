using System.Net;

namespace PigChain.Models.Http;

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