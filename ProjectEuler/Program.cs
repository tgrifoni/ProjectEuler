using System;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Problem 1: {Problem.SumAllNaturalNumbersMultiplesOfThreeAndFive(1000)}");
            Console.WriteLine($"Problem 2: {Problem.SumEvenFibonacciNumbers(40)}");
            Console.WriteLine($"Problem 3: {Problem.GetLargestPrimeFactorOf(600851475143)}");
            Console.WriteLine($"Problem 4: {Problem.GetLargestPalindromeProduct()}");
            Console.WriteLine($"Problem 5: {Problem.GetSmallestPositiveNumberEvenlyDivisibleBy(20)}");
            Console.WriteLine($"Problem 6: {Problem.SubtractSumSquareOf(100)}");
        }
    }
}
