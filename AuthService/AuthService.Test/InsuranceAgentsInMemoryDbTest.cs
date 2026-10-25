using AuthService.DataAccess;
using Xunit;

namespace AuthService.Test;

public class InsuranceAgentsInMemoryDbTest
{
    [Fact]
    public void FindByLoginReturnsNullWhenAgentDoesNotExist()
    {
        var agents = new InsuranceAgentsInMemoryDb();

        Assert.Null(agents.FindByLogin("missing-agent"));
    }
}
