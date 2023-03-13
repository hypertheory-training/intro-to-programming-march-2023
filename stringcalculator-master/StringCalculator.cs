using System;
namespace StringCalculator;

public class StringCalculator
{
    private readonly Ilogger _logger;
    public StringCalculator(Ilogger logger)
    {
        _logger = logger;
    }


    public int Add(string numbers)
    {
        int total = numbers == "" ? 0: numbers.Split(',', '\n')
            .Select(int.Parse)
            .Sum();
        _logger.Write(total.ToString());
        return total;
    }
}

public class Ilogger
{
}