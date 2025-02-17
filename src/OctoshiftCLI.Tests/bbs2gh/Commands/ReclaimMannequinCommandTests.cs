using OctoshiftCLI.BbsToGithub.Commands;
using Xunit;

namespace OctoshiftCLI.Tests.BbsToGithub.Commands;

public class ReclaimMannequinCommandTests
{
    [Fact]
    public void Should_Have_Options()
    {
        var command = new ReclaimMannequinCommand();
        Assert.NotNull(command);
        Assert.Equal("reclaim-mannequin", command.Name);
        Assert.Equal(8, command.Options.Count);

        TestHelpers.VerifyCommandOption(command.Options, "github-org", true);
        TestHelpers.VerifyCommandOption(command.Options, "csv", false);
        TestHelpers.VerifyCommandOption(command.Options, "mannequin-user", false);
        TestHelpers.VerifyCommandOption(command.Options, "mannequin-id", false);
        TestHelpers.VerifyCommandOption(command.Options, "target-user", false);
        TestHelpers.VerifyCommandOption(command.Options, "force", false);
        TestHelpers.VerifyCommandOption(command.Options, "github-pat", false);
        TestHelpers.VerifyCommandOption(command.Options, "verbose", false);
    }
}
