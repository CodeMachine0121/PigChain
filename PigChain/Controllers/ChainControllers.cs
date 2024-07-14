using Microsoft.AspNetCore.Mvc;
using PigChain.Models.Chain;
using PigChain.Models.Http;
using PigChain.Repositories;
using PigChain.Repositories.Interfaces;

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
        var block = await chainService.GetBlockBy();
        return PigApiResponse.SuccessWithData(block);
    }
}

public interface IChainService
{
    Task<Block> GetBlockBy();
}

public class ChainService : IChainService
{
    public async Task<Block> GetBlockBy()
    {
        return new Block()
        {
            Message = "First Block Get by Id"
        };
        
    }
}