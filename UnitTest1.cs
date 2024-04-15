namespace TestProject1;

public class UnitTest1
{
    public static double CalcT(double v)
    {
        double t = 2 * v / 9.8;
        return t;
    }

    [Fact]
    public void CalcTTest1()
    {
        double v = 4.9;
        double expected = 1;
        double actual = CalcT(v);
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void CalcTTest2()
    {
        double v = -4.9;
        double expected = -1;
        double actual = CalcT(v);
        Assert.Equal(expected, actual);
    }
}