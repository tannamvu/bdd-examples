using System;
using BDDExamples.Services;

namespace BDDExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculatorService = new CalculatorService();
            Console.WriteLine(string.Format("23 + 23 = {0}",calculatorService.Add(23, 23)));
            Console.WriteLine(string.Format("28 - 23 = {0}", calculatorService.Subtract(28, 23)));
            Console.WriteLine(string.Format("23 * 23 = {0}", calculatorService.Multiply(23, 23)));
            Console.ReadLine();
        }
    }
}
