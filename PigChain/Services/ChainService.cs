using PigChain.Models.Chain;
using PigChain.Services.Interfaces;

namespace PigChain.Services;

public class ChainService : IChainService
{
    public async Task<Block> GetBlockBy(int id)
    {
        return new Block()
        {
            Id = id,
            Message = "First Block Get by Id"
        };
        
    }
}