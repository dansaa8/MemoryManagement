namespace SkalProj_Datastrukturer_Minne.Tests;

public class RecursiveEven
{
    [Fact]
    public void WithArgVal1()
    {
        int expected = 2;
        Assert.Equal(expected, Util.RecursiveEven(1));
    }

    [Fact]
    public void WithArgVal3()
    {
        int expected = 6;
        Assert.Equal(expected, Util.RecursiveEven(3));
    }

    [Fact]
    public void WithArgVal5()
    {
        int expected = 10;
        Assert.Equal(expected, Util.RecursiveEven(5));
    }
}