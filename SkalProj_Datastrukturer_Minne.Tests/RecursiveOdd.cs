namespace SkalProj_Datastrukturer_Minne.Tests;

public class RecursiveOdd
{
    [Fact]
    public void WithArgVal1()
    {
        int expected = 1;
        Assert.Equal(expected, Util.RecursiveOdd(1));
    }

    [Fact]
    public void WithArgVal3()
    {
        int expected = 5;
        Assert.Equal(expected, Util.RecursiveOdd(3));
    }

    [Fact]
    public void WithArgVal5()
    {
        int expected = 9;
        Assert.Equal(expected, Util.RecursiveOdd(5));
    }

    [Fact]
    public void WithArgVal7()
    {
        int expected = 13;
        Assert.Equal(expected, Util.RecursiveOdd(7));
    }
}