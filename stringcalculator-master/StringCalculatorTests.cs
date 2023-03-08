
namespace StringCalculator;
private StringCalculator _calculator;

public class StringCalculatorTests
{
    public void EmptyStringReturnsZero()
    {
        _calculator = new StringCalculator();

    }

    [Fact]
    public void EmptyStringReturnZero()
    {
        var result = _calculator.Add("");

        Assert.Equal(0, result);
    }
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
[InlineData("1\n2", 3)]
[InlineData("1\n10", 11)]
[InlineData("99\n5", 104)]
[InlineData("99\n5,1", 105)]

public void NewLineDelimeters(string numbers, int expected)
{
    var result = _calculator.Add(numbers);

    Assert.Equal(expected, result);
}

