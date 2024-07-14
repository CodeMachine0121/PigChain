using PigChain.Models.Chain;
using PigChain.Repositories.Interfaces;
using PigChain.Services.Interfaces;

namespace PigChain.Services;

public class ChainService(IChainRepository chainRepository) : IChainService
{

    public async Task<Block> GetBlockBy(int id)
    {
        var block = await chainRepository.Fetch(id);
        
        return block;
    }
}