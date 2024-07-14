using PigChain.Models.Chain;

namespace PigChain.Repositories.Interfaces;

public interface IChainRepository
{
    Task<List<Block>> FetchAll();
}