using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public static class Problem
    {
        public static int SumAllNaturalNumbersMultiplesOfThreeAndFive(int n) => 
            Enumerable.Range(3, n - 3)
            .Where(n => n % 3 == 0 || n % 5 == 0)
            .Sum();
            
        public static int SumEvenFibonacciNumbers(int n)
        {
            static int Fibonacci(int order)
            {
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
                for (int j = 999; j > 99; j--)
                {
                    var product = i * j;
                    var productString = product.ToString();
                    var isPalindrome = productString.Reverse().SequenceEqual(productString);

                    if (isPalindrome) yield return product;
                }
            };

            var allThreeDigitProductPalindromes = GetAllThreeDigitProductPalindromes();
            return allThreeDigitProductPalindromes.Max();
        }

        public static long GetSmallestPositiveNumberEvenlyDivisibleBy(int number)
        {
            static long GetGreatestCommonDivisor(long first, long second) => second == 0 ? first : GetGreatestCommonDivisor(second, first % second);
            static long GetLeastCommonMultiple(long first, long second) => first * second / GetGreatestCommonDivisor(first, second);

            var range = Enumerable.Range(1, number).Select(number => (long) number);
            var smallestPositiveNumber = range.Aggregate(GetLeastCommonMultiple);

            return smallestPositiveNumber;
        }

        public static int SubtractSumSquareOf(int number)
        {
            var range = Enumerable.Range(1, number);

            var sumOfTheSquares = range.Select(n => (int) Math.Pow(n, 2)).Sum();
            var squareOfTheSum = (int) Math.Pow(range.Sum(), 2);

            return squareOfTheSum - sumOfTheSquares;
        }
        
        public static List<string> GetTopQuotedToysAmzn(List<string> toys, List<string> quotes, int topToys)
        {
            var topQuotedToys = toys.Select<string, (string Toy, int Count)>(toy => (toy, quotes.Count(quote => quote.Contains(toy, StringComparison.OrdinalIgnoreCase))))
                .Where(quotedToy => quotedToy.Count > 0)
                .OrderByDescending(quotedToy => quotedToy.Count)
                .Select(quotedToy => quotedToy.Toy)
                .Take(topToys)
                .ToList();

            return topQuotedToys;
        }
    }
}
