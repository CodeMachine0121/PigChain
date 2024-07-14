using Microsoft.AspNetCore.Mvc;
using PigChain.Models.Http;
using PigChain.Repositories;
using PigChain.Repositories.Interfaces;

namespace PigChain.Controllers;

[Route("api/[controller]")]
public class ChainControllers(IChainRepository chainRepository) : ControllerBase
{

    [HttpGet("")]
    public async Task<PigApiResponse> GetAll()
    {
        var allChain = await chainRepository.FetchAll();
        return PigApiResponse.SuccessWithData(allChain);
    }
 
}