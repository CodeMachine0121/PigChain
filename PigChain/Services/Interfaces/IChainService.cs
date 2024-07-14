using PigChain.Models.Chain;

namespace PigChain.Services.Interfaces;

public interface IChainService
{
    Task<Block> GetBlockBy(int id);
}