using ProjectEuler;
using Xunit;

namespace ProjectEulerTest
{
    public class ProblemTest
    {
        [Fact]
        public void SumAllNaturalNumbersMultiplesOfThreeAndFive_WhenBelowTen_SumShouldBe23()
        {
            var n = 10;
            var expectedSum = 23;

            var actualSum = Problem.SumAllNaturalNumbersMultiplesOfThreeAndFive(n);

            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void SumAllNaturalNumbersMultiplesOfThreeAndFive_WhenBelowOneThousand_SumShouldBe233168()
        {
            var n = 1000;
            var expectedSum = 233168;

            var actualSum = Problem.SumAllNaturalNumbersMultiplesOfThreeAndFive(n);

            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void SumEvenFibonacciNumbers_WhenFirstTen_SumShouldBe44()
        {
            var n = 10;
            var expectedSum = 44;

            var actualSum = Problem.SumEvenFibonacciNumbers(n);

            Assert.Equal(expectedSum, actualSum);
        }

        [Theory]
        [InlineData(34)]
        [InlineData(35)]
        [InlineData(321)]
        [InlineData(213421)]
        public void SumEvenFibonacciNumbers_WhenMoreThan34_SumShouldBe4613732(int order)
        {
            var expectedSum = 4613732;

            var actualSum = Problem.SumEvenFibonacciNumbers(order);

            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void GetLargestPrimeFactorOf_WhenNumberIs13195_LargestPrimeFactorShouldBe29()
        {
            var number = 13195;
            var expectedPrimeFactor = 29;

            var actualLargestPrimeFactor = Problem.GetLargestPrimeFactorOf(number);

            Assert.Equal(expectedPrimeFactor, actualLargestPrimeFactor);
        }

        [Fact]
        public void GetLargestPrimeFactorOf_WhenNumberIs600851475143_LargestPrimeFactorShouldBe6857()
        {
            var number = 600851475143;
            var expectedPrimeFactor = 6857;

            var actualLargestPrimeFactor = Problem.GetLargestPrimeFactorOf(number);

            Assert.Equal(expectedPrimeFactor, actualLargestPrimeFactor);
        }

        [Fact]
        public void GetLargestPalindromeProduct_WhenProductOfThreeDigitNumbers_ShouldBe906609()
        {
            var expectedLargestPalindrome = 906609;

            var actualLargestPalindrome = Problem.GetLargestPalindromeProduct();

            Assert.Equal(expectedLargestPalindrome, actualLargestPalindrome);
        }

        [Fact]
        public void GetSmallestPositiveNumberEvenlyDivisibleBy_WhenNumberIsTen_ShouldBe2520()
        {
            var number = 10;
            var expectedSmallestPositiveNumber = 2520;

            var actualSmallestPositiveNumber = Problem.GetSmallestPositiveNumberEvenlyDivisibleBy(number);

            Assert.Equal(expectedSmallestPositiveNumber, actualSmallestPositiveNumber);
        }

        [Fact]
        public void GetSmallestPositiveNumberEvenlyDivisibleBy_WhenNumberIsTwenty_ShouldBe232792560()
        {
            var number = 20;
            var expectedSmallestPositiveNumber = 232792560;

            var actualSmallestPositiveNumber = Problem.GetSmallestPositiveNumberEvenlyDivisibleBy(number);

            Assert.Equal(expectedSmallestPositiveNumber, actualSmallestPositiveNumber);
        }

        [Fact]
        public void SubtractSumSquareOf_WhenFirstTen_ShouldBe2640()
        {
            var number = 10;
            var expectedDifference = 2640;

            var actualDifference = Problem.SubtractSumSquareOf(number);

            Assert.Equal(expectedDifference, actualDifference);
        }

        [Fact]
        public void SubtractSumSquareOf_WhenFirstOneHundred_ShouldBe25164150()
        {
            var number = 100;
            var expectedDifference = 25164150;

            var actualDifference = Problem.SubtractSumSquareOf(number);

            Assert.Equal(expectedDifference, actualDifference);
        }

        [Fact]
        public void GetTopToysAmzn_WhenMostQuotedToysAreBetaAndDeltacellular_ShouldReturnBetaAndDeltacellular()
        {
            var toys = new System.Collections.Generic.List<string> { "anacell", "betacellular", "cetracular", "deltacellular", "eurocell" };
            var quotes = new System.Collections.Generic.List<string>
            {
                "I love anacell Best services provided by anacell",
                "betacellular has great service",
                "deltacellular blablabla betacellular",
                "cetracular blablabla eurocell",
                "betacellular blabla deltacellular"
            };
            var topToys = 2;

            var topQuotedToys = Problem.GetTopQuotedToysAmzn(toys, quotes, topToys);

            Assert.Equal("betacellular", topQuotedToys[0]);
            Assert.Equal("deltacellular", topQuotedToys[1]);
            Assert.Equal(topToys, topQuotedToys.Count);
        }
    }
}
