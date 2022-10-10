namespace BaseProject.Tests;

public class Tests
{
    [Test]
    public void Test1()
    {
        new RenameMe().ReturnsTrue().Should().BeTrue();
    }
}