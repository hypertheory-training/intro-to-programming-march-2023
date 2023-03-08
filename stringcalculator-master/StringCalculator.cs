
using System.Reflection.Metadata.Ecma335;

namespace StringCalculator;

public class StringCalculator
{

  public int Add(string numbers)
    {
        if(numbers.Contains(","))
        {
            var CommaAt = 1;

            var lhs = int.Parse(numbers.Substring(0, CommaAt));
            var rhs = int.Parse(numbers.Substring(CommaAt + 1));
            return lhs + rhs;

        }
        return numbers == "" ? 0 : int.Parse(numbers);
    }

    }

