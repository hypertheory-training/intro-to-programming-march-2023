
using System.Data;

namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        var allowedDelimeters = new List<char> {  ',', '\n'};

        if (numbers == "") { return 0; }
        var total = 0;

        foreach(var n in numbers.Split(allowedDelimeters.ToArray())) {
            total += int.Parse(n);
        }
        return total;

    }
}
