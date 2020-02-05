using ProjectEuler;
using Xunit;

namespace ProjectEulerTest
{
    public class ExerciseTest
    {
        [Fact]
        public void SumAllNaturalNumbersMultiplesOfThreeAndFive_WhenBelowTen_SumShouldBe23()
        {
            var n = 10;
            var expectedSum = 23;

            var actualSum = Exercise.SumAllNaturalNumbersMultiplesOfThreeAndFive(n);

            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void SumAllNaturalNumbersMultiplesOfThreeAndFive_WhenBelowOneThousand_SumShouldBe233168()
        {
            var n = 1000;
            var expectedSum = 233168;

            var actualSum = Exercise.SumAllNaturalNumbersMultiplesOfThreeAndFive(n);

            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void SumEvenFibonacciNumbers_WhenFirstTen_SumShouldBe44()
        {
            var n = 10;
            var expectedSum = 44;

            var actualSum = Exercise.SumEvenFibonacciNumbers(n);

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

            var actualSum = Exercise.SumEvenFibonacciNumbers(order);

            Assert.Equal(expectedSum, actualSum);
        }

        [Fact]
        public void GetLargestPrimeFactorOf_WhenNumberIs13195_LargestPrimeFactorShouldBe29()
        {
            var number = 13195;
            var expectedPrimeFactor = 29;

            var actualLargestPrimeFactor = Exercise.GetLargestPrimeFactorOf(number);

            Assert.Equal(expectedPrimeFactor, actualLargestPrimeFactor);
        }

        [Fact]
        public void GetLargestPrimeFactorOf_WhenNumberIs600851475143_LargestPrimeFactorShouldBe6857()
        {
            var number = 600851475143;
            var expectedPrimeFactor = 6857;

            var actualLargestPrimeFactor = Exercise.GetLargestPrimeFactorOf(number);

            Assert.Equal(expectedPrimeFactor, actualLargestPrimeFactor);
        }

        [Fact]
        public void GetLargestPalindromeProduct_WhenProductOfThreeDigitNumbers_ShouldBe906609()
        {
            var expectedLargestPalindrome = 906609;

            var actualLargestPalindrome = Exercise.GetLargestPalindromeProduct();

            Assert.Equal(expectedLargestPalindrome, actualLargestPalindrome);
        }

        [Fact]
        public void GetSmallestPositiveNumberEvenlyDivisibleBy_WhenNumberIsTen_ShouldBe2520()
        {
            var number = 10;
            var expectedSmallestPositiveNumber = 2520;

            var actualSmallestPositiveNumber = Exercise.GetSmallestPositiveNumberEvenlyDivisibleBy(number);

            Assert.Equal(expectedSmallestPositiveNumber, actualSmallestPositiveNumber);
        }

        [Fact]
        public void GetSmallestPositiveNumberEvenlyDivisibleBy_WhenNumberIsTwenty_ShouldBe232792560()
        {
            var number = 20;
            var expectedSmallestPositiveNumber = 232792560;

            var actualSmallestPositiveNumber = Exercise.GetSmallestPositiveNumberEvenlyDivisibleBy(number);

            Assert.Equal(expectedSmallestPositiveNumber, actualSmallestPositiveNumber);
        }
    }
}
