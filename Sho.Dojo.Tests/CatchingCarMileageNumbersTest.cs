using Sho.Dojo.Katas;
using System.Collections.Generic;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class CatchingCarMileageNumbersTest
    {
        [Fact]
        public void NumberInAwesomePhrasesMoreThanHundredIsInteresting()
        {
            // act
            int actual = CatchingCarMileageNumbers.IsInteresting(857, new List<int>() { 3, 857 });

            // assert
            Assert.Equal(2, actual);
        }

        [Fact]
        public void FollowedByDigitsZerosIsInteresting()
        {
            // act
            int actual = CatchingCarMileageNumbers.IsInteresting(800, new List<int>() {});

            // assert
            Assert.Equal(2, actual);
        }

        [Fact]
        public void EveryDigitSameNumberIsInteresting()
        {
            // act
            int actual = CatchingCarMileageNumbers.IsInteresting(3333, new List<int>() { });

            // assert
            Assert.Equal(2, actual);
        }

        [Theory]
        [InlineData(234567890)]
        public void DigitsIncrementingIsInteresting(int number)
        {
            // act
            int actual = CatchingCarMileageNumbers.IsInteresting(number, new List<int>() { });

            // assert
            Assert.Equal(2, actual);
        }

        [Theory]
        [InlineData(43210)]
        [InlineData(3210)]
        public void DigitsDecrementingIsInteresting(int number)
        {
            // act
            int actual = CatchingCarMileageNumbers.IsInteresting(number, new List<int>() { });

            // assert
            Assert.Equal(2, actual);
        }

        [Theory]
        [InlineData(234432)]
        [InlineData(565)]
        public void PalindromeIsInteresting(int number)
        {
            // act
            int actual = CatchingCarMileageNumbers.IsInteresting(number, new List<int>() { });

            // assert
            Assert.Equal(2, actual);
        }

        [Theory]
        [InlineData(11209)]
        [InlineData(11210)]
        [InlineData(1336)]
        [InlineData(98)]
        [InlineData(109)]
        [InlineData(110)]
        public void AlmostInterestingTest(int number)
        {
            // arrange
            List<int> awesomePhrases = new List<int>() { 1337, 256 };

            // act
            int actual = CatchingCarMileageNumbers.IsInteresting(number, awesomePhrases);

            // assert
            Assert.Equal(1, actual);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(30)]
        public void NotInterestingTest(int number)
        {
            // arrange
            List<int> awesomePhrases = new List<int>() { 1337, 256 };

            // act
            int actual = CatchingCarMileageNumbers.IsInteresting(number, awesomePhrases);

            // assert
            Assert.Equal(0, actual);
        }
    }
}
