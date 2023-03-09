
namespace StringCalculator;

public class StringCalculatorTests
{

    private StringCalculator _calculator;

    public StringCalculatorTests()
    {
        _calculator = new StringCalculator();
    }

    [Fact]
    public void EmptyStringReturnsZero()
    {
        

        var result = _calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    [InlineData("108", 108)]
    public void SingleDigits(string numbers, int expected)
    {

        var result = _calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("2,3", 5)]
    [InlineData("10,20",30 )]
    [InlineData("10,108", 118)]
    public void TwoDigits(string numbers, int expected)
    {

        var result = _calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1\n2", 3)]
    [InlineData("1\n10", 11)]
    [InlineData("99\n5", 104)]
    [InlineData("99\n5,1", 105)]
   
    public void NewLineDelimeters(string numbers, int expected)
    {

        var result = _calculator.Add(numbers);

        Assert.Equal(expected, result);
    }
}
