using FluentAssertions;
using NUnit.Framework;
using PigChain.Services;

namespace UnitTests.Services;

[TestFixture]
public class ChainServiceTests
{
    [Test]
    public async Task should_get_by_id()
    {
        var chainService = new ChainService();
        var blockBy = await chainService.GetBlockBy(1);
        blockBy.Id.Should().Be(1);
    }
    
}