using КалькуляторЛогика;

namespace КалькуляторТесты;

public class UnitTest1
{
    readonly Калькулятор Калькулятор = new();

    [Fact]
    public void Test1()
    {
        Assert.Equal(3, Калькулятор.Сложить(1, 2));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal(1, Калькулятор.Вычесть(2, 1));
    }

    [Fact]
    public void Test3()
    {
        Assert.Equal(6, Калькулятор.Умножить(2, 3));
    }

    [Fact]
    public void Test4()
    {
        Assert.Equal(3, Калькулятор.Разделить(6, 2));
    }

    [Fact]
    public void Test5()
    {
        Assert.Equal(8, Калькулятор.ВозвестиВСтепень(2, 3));
    }

    [Fact]
    public void Test6()
    {
        Assert.Equal(2, Калькулятор.ИзвлечьКорень(4));
    }

    [Fact]
    public void Test7()
    {
        Assert.Equal(3, Калькулятор.Сложить(1, 2));
        Assert.Equal(1, Калькулятор.Вычесть(2, 1));
        Assert.Equal(6, Калькулятор.Умножить(2, 3));
        Assert.Equal(3, Калькулятор.Разделить(6, 2));
        Assert.Equal(8, Калькулятор.ВозвестиВСтепень(2, 3));
        Assert.Equal(2, Калькулятор.ИзвлечьКорень(4));
    }

}