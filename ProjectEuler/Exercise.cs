using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public static class Exercise
    {
        public static int SumAllNaturalNumbersMultiplesOfThreeAndFive(int n) => 
            Enumerable.Range(3, n - 3)
            .Where(n => n % 3 == 0 || n % 5 == 0)
            .Sum();
            
        public static int SumEvenFibonacciNumbers(int n)
        {
            static int Fibonacci(int order)
            {
                //if (order <= 2) return order;
                //return Fibonacci(order - 2) + Fibonacci(order - 1);
                var fiveSqrt = Math.Sqrt(5);
                var phi = (1 + fiveSqrt) / 2;

                return (int)Math.Round(Math.Pow(phi, order) / fiveSqrt);
            };

            const int LimitValue = 4_000_000;            
            var sum = 0;
            for (int i = 2; i <= n; i++)
            {
                var fibonacci = Fibonacci(i);
                if (fibonacci > LimitValue) break;
                if (fibonacci % 2 == 0) sum += fibonacci;
            }
            return sum;
        }

        public static int GetLargestPrimeFactorOf(int number)
        {
            static IEnumerable<int> GetAllPrimeFactorsOf(int number)
            {
                var numberSqrt = Math.Sqrt(number);
                for (int div = 2; div <= numberSqrt; div++)
                {
                    while (number % div == 0)
                    {
                        yield return div;
                        number /= div;
                    }
                }
            };

            return GetAllPrimeFactorsOf(number).Max();
        }

        public static long GetLargestPrimeFactorOf(long number)
        {
            static IEnumerable<long> GetAllPrimeFactorsOf(long number)
            {
                var numberSqrt = Math.Sqrt(number);
                for (long div = 2; div <= numberSqrt; div++)
                {
                    while (number % div == 0)
                    {
                        yield return div;
                        number /= div;
                    }
                }
            };

            return GetAllPrimeFactorsOf(number).Max();
        }

        public static int GetLargestPalindromeProduct()
        {
            static IEnumerable<int> GetAllThreeDigitProductPalindromes()
            {
                for (int i = 999; i > 99; i--)
                {
                    for (int j = 999; j > 99; j--)
                    {
                        var product = i * j;
                        var productString = product.ToString();
                        var isPalindrome = productString.Reverse().SequenceEqual(productString);

                        if (isPalindrome) yield return product;
                    }
                }
            };

            var allThreeDigitProductPalindromes = GetAllThreeDigitProductPalindromes();
            return allThreeDigitProductPalindromes.Max();
        }

        public static long GetSmallestPositiveNumberEvenlyDivisibleBy(int number)
        {
            static long GetGreaterCommonDivisor(long first, long second) => second == 0 ? first : GetGreaterCommonDivisor(second, first % second);
            static long GetLeastCommonMultiple(long first, long second) => first * second / GetGreaterCommonDivisor(first, second);

            var range = Enumerable.Range(1, number).Select(number => (long) number);
            var smallestPositiveNumber = range.Aggregate(GetLeastCommonMultiple);

            return smallestPositiveNumber;
        }
    }
}
