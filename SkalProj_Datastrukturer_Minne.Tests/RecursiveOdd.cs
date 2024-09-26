namespace SkalProj_Datastrukturer_Minne.Tests;

public class RecursiveOdd
{
    [Fact]
    public void WithArgVal1()
    {
        Assert.Equal(1, Util.RecursiveOdd(1));
    }

    [Fact]
    public void WithArgVal3()
    {
        Assert.Equal(5, Util.RecursiveOdd(3));
    }

    [Fact]
    public void WithArgVal5()
    {
        Assert.Equal(9, Util.RecursiveOdd(5));
    }

    [Fact]
    public void WithArgVal6()
    {
        Assert.Equal(13, Util.RecursiveOdd(7));
    }
}