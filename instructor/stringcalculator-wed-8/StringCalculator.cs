
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }
        var delimiters = new List<char> { '\n', ',' };
        if(numbers.StartsWith("//"))
        {
            var delim = numbers[2];
            delimiters.Add(delim);
            numbers = numbers.Substring(4);

        }
       

        var nums = numbers.Split(delimiters.ToArray())
            .Select(int.Parse);

        var negatives = nums.Where(n => n < 0);
        if(negatives.Count() > 0)
        {
            var message = string.Join(',', negatives.ToArray());
            throw new NoNegativeNumbersException(message);
        }

        return nums.Sum();

    }
}
