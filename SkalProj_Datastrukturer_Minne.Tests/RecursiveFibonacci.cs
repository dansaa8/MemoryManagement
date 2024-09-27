namespace SkalProj_Datastrukturer_Minne.Tests;

public class RecursiveFibonacci
{
    // 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144...
    [Fact]
    public void WithArg0()
    {
        int expected = 0;
        Assert.Equal(expected, Util.RecursiveFibonacci(0));
    }

    [Fact]
    public void WithArg1()
    {
        int expected = 1;
        Assert.Equal(expected, Util.RecursiveFibonacci(1));
    }

    [Fact]
    public void WithArg2()
    {
        int expected = 1;
        Assert.Equal(expected, Util.RecursiveFibonacci(2));
    }

    [Fact]
    public void WithArg3()
    {
        int expected = 2;
        Assert.Equal(expected, Util.RecursiveFibonacci(3));
    }

    [Fact]
    public void WithArg4()
    {
        int expected = 3;
        Assert.Equal(expected, Util.RecursiveFibonacci(4));
    }

    [Fact]
    public void WithArg5()
    {
        int expected = 5;
        Assert.Equal(expected, Util.RecursiveFibonacci(5));
    }
    
    [Fact]
    public void WithArg6()
    {
        int expected = 8;
        Assert.Equal(expected, Util.RecursiveFibonacci(6));
    }
}