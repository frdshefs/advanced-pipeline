using System;

class Program
{
    static void Main()
    {
        var calculator = new Calculator();
        var stats = new StatisticsCalculator();

        Console.WriteLine(""Advanced Calculator"");
        Console.WriteLine(""==================="");

        Console.WriteLine($""5 + 3 = {calculator.Add(5, 3)}"");
        Console.WriteLine($""2^4 = {calculator.Power(2, 4)}"");
        Console.WriteLine($""5! = {calculator.Factorial(5)}"");
        Console.WriteLine($""Is 17 prime? {calculator.IsPrime(17)}"");
        Console.WriteLine($""Average [1,2,3,4,5] = {stats.CalculateAverage(1, 2, 3, 4, 5)}"");

        Console.WriteLine(""\nAll operations completed successfully!"");
    }
}
