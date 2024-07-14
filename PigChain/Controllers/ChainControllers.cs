using Microsoft.AspNetCore.Mvc;
using PigChain.Models.Http;
using PigChain.Repositories;
using PigChain.Repositories.Interfaces;
using PigChain.Services;
using PigChain.Services.Interfaces;

namespace PigChain.Controllers;

[Route("api/[controller]")]
public class ChainControllers(IChainRepository chainRepository, IChainService chainService) : ControllerBase
{

    [HttpGet("")]
    public async Task<PigApiResponse> GetAll()
    {
        var allChain = await chainRepository.FetchAll();
        return PigApiResponse.SuccessWithData(allChain);
    }


    [HttpGet("{id}")]
    public async Task<PigApiResponse> GetBlockById(int id)
    {
        var block = await chainService.GetBlockBy(id);
        return PigApiResponse.SuccessWithData(block);
    }
}