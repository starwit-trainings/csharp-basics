using FootballService;

namespace FootballService.Tests;

public class UnitTest1
{
    [Fact]
    public void TestDataStructures()
    {
        FootballManager fm = new FootballManager();
        fm.setup();
        Assert.True(fm.Clubs.Count == 4);
        Assert.True(fm.Leagues.Count == 3);
        Assert.Equal(4,fm.Clubs.Count);
    }
}