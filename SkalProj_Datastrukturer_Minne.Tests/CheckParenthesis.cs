namespace SkalProj_Datastrukturer_Minne.Tests;

public class CheckParenthesis
{
    [Fact]
    public void ReturnTrue()
    {
        // Arrange
        string testString = "[hej()]";

        // Act
        bool result = Util.CheckParenthesis(testString);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void ReturnTrue2()
    {
        // Arrange
        string testString = "([{}]({}))";

        // Act
        bool result = Util.CheckParenthesis(testString);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void ReturnTrue3()
    {
        // Arrange
        string testString = "List<int> lista = new List<int>(){2, 3, 4};";

        // Act
        bool result = Util.CheckParenthesis(testString);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void ReturnFalse()
    {
        // Arrange
        string testString = "([)hej()]";

        // Act
        bool result = Util.CheckParenthesis(testString);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void ReturnFalse2()
    {
        // Arrange
        string testString = "({)}";

        // Act
        bool result = Util.CheckParenthesis(testString);

        // Assert
        Assert.False(result);
    }
}