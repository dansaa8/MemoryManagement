namespace SkalProj_Datastrukturer_Minne.Tests;

public class IterativeEven
{
    
    [Fact]
    public void GivenArg1Return2()
    {
        int expected = 2;
        Assert.Equal(expected, Util.IterativeEven(1));
    }
    
    [Fact]
    public void GivenArg2Return4()
    {
        int expected = 4;
        Assert.Equal(expected, Util.IterativeEven(2));
    }
    
    [Fact]
    public void GivenArg3Return6()
    {
        int expected = 6;
        Assert.Equal(expected, Util.IterativeEven(3));
    } 
    
    [Fact]
    public void GivenArg4Return8()
    {
        int expected = 8;
        Assert.Equal(expected, Util.IterativeEven(4));
    }
}