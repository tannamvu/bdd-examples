using BDDExamples.Interfaces;

namespace BDDExamples.Services
{
    public class CalculatorService : ICalculatorService
    {
        public int Add(int valueA, int valueB)
        {
            return valueA + valueB;
        }

        public int Subtract(int valueA, int valueB)
        {
            return valueB - valueA;
        }

        public int Multiply(int valueA, int valueB)
        {
            return valueA*valueB;
        }
    }
}
