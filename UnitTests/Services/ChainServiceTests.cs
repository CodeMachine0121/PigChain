using FluentAssertions;
using NSubstitute;
using NUnit.Framework;
using PigChain.Models.Chain;
using PigChain.Repositories.Interfaces;
using PigChain.Services;

namespace UnitTests.Services;

[TestFixture]
public class ChainServiceTests
{
    private ChainService _chainService;
    private IChainRepository? _chainRepository;

    [SetUp]
    public void SetUp()
    {
        _chainRepository = Substitute.For<IChainRepository>();
        _chainService = new ChainService(_chainRepository);
    }

    [Test]
    public async Task should_get_by_id_via_repository()
    {
        _chainRepository!.Fetch(Arg.Any<int>()).Returns(new Block
        {
            Id = 1
        });

        var blockBy = await _chainService.GetBlockBy(1);

        await _chainRepository.Received().Fetch(Arg.Is(1));
        blockBy.Id.Should().Be(1);
    }

}