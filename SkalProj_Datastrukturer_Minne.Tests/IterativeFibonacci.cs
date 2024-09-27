namespace SkalProj_Datastrukturer_Minne.Tests;

public class IterativeFibonacci
{
    // 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144...
    [Fact]
    public void GivenArg0ReturnEmptyList()
    {
        Assert.Empty(Util.IterativeFibonacci(0));
    }

    [Fact]
    public void GivenArg1ReturnListWith1Element()
    {
        // Arrange
        List<int> expectedList = new List<int>() { 1 };

        // Act 
        List<int> actualList = Util.IterativeFibonacci(1);

        // Assert
        Assert.Equal(expectedList, actualList);
    }

    [Fact]
    public void GivenArg2ReturnListWith2Element()
    {
        // Arrange
        List<int> expectedList = new List<int>() { 1, 1 };

        // Act 
        List<int> actualList = Util.IterativeFibonacci(2);

        // Assert
        Assert.Equal(expectedList, actualList);
    }

    [Fact]
    public void GivenArg3ReturnListWith3Element()
    {
        // Arrange
        List<int> expectedList = new List<int>() { 1, 1, 2 };

        // Act 
        List<int> actualList = Util.IterativeFibonacci(3);

        // Assert
        Assert.Equal(expectedList, actualList);
    }

    [Fact]
    public void GivenArg12ReturnListWith12Element()
    {
        // Arrange
        List<int> expectedList = new List<int>()
        {
            1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144
        };

        // Act 
        List<int> actualList = Util.IterativeFibonacci(12);

        // Assert
        Assert.Equal(expectedList, actualList);
    }
}