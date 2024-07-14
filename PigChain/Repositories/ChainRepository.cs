using PigChain.Controllers;
using PigChain.Models.Chain;
using PigChain.Repositories.Interfaces;

namespace PigChain.Repositories;

public class ChainRepository : IChainRepository
{
    public async Task<List<Block>> FetchAll()
    {
         return  new List<Block>()
        {
            new Block()
            {
                Message = "First Block Message", 
            }
        };
    }

    public async Task<Block> Fetch(int blockId)
    {
        return new Block(){};
        
    }
}