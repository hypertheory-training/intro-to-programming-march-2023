
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }
    [Theory]
    [InlineData("4",4)]
    [InlineData("5",5)]
    [InlineData("1242",1242)]
    public void SingleDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData("4,4", 8)]
    [InlineData("2,2", 4)]
    [InlineData("193,7", 200)]
    [InlineData("580,120", 700)]
   
    
    public void TwoDigits(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("1,2,3", 6)]
    [InlineData("1,2,3,4,5,6,7,8,9", 45)]

    public void UnknownNumbers(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }
    [Theory]
    [InlineData("1\n3", 4)]
    [InlineData("2\n3", 5)]
    [InlineData("1\n2,3", 6)]

    public void NewLines(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("//;\n1;2", 3)]
    [InlineData("//;\n3;2", 5)]
    [InlineData("//*\n1*1", 2)]
    [InlineData("//X\n1X2,3,4\n1", 11)]
    public void CustomDelimeters(string numbers, int expected)
    {
        var calculator = new StringCalculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("-1", "-1")]
    [InlineData("1,2\n-4", "-4")]
    [InlineData("1,2\n-4,-3", "-4,-3")]
    
    
    public void NegativeNumbersThrows(string numbers, string message)
    {
        var calculator = new StringCalculator();

        var exception = Assert.Throws<NoNegativeNumbersException>(() =>
        {
            calculator.Add(numbers);
            
        });
        
        Assert.StartsWith(message, exception.Message);

       
    }

}
