using Sho.Dojo.Katas;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class ConwaysGameOfLifeUnlimitedEditionTest
    {
        [Fact]
        public void EmptyUniverseTest()
        {
            Assert.Equal(new int[0, 0], ConwaysGameOfLifeUnlimitedEdition.GetGeneration(new int[0, 0], 2));
        }

        [Fact]
        public void EmptyUniverseZeroGenerationTest()
        {
            var cells = new int[,] {
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0 }
            };

            Assert.Equal(new int[0, 0], ConwaysGameOfLifeUnlimitedEdition.GetGeneration(cells, 0));
        }

        [Fact]
        public void GliderInitialWorldTest()
        {
            var cells = new int[,] { { 0, 1, 1 }, { 1, 0, 0 }, { 0, 0, 1 } };
            var actual = ConwaysGameOfLifeUnlimitedEdition.GetGeneration(cells, 2);

            Assert.Equal(new int[0,0], actual);
        }

        [Fact]
        public void ThreeBySixInitialWorldTest()
        {
            var expected = new int[,] {
                { 0, 1, 1, 0, 0 },
                { 1, 0, 0, 1, 0, },
                { 1, 0, 0, 0, 1 },
                { 0, 1, 0, 1, 0 }
            };

            var cells = new int[,] {
                { 1, 1, 0, 0, 0, 0 },
                { 0, 0, 1, 1, 1, 1 },
                { 0, 0, 0, 0, 1, 1 }
            };

            var actual = ConwaysGameOfLifeUnlimitedEdition.GetGeneration(cells, 2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CorrectCroppingTest()
        {
            var expected = new int[,] {
                { 1, 0, 1 },
                { 0, 1, 1 },
                { 0, 1, 0 }
            };
            var cells = new int[,] {
                { 1, 0, 0 },
                { 0, 1, 1 },
                { 1, 1, 0 }
            };

            var actual = ConwaysGameOfLifeUnlimitedEdition.GetGeneration(cells, 2);

            Assert.Equal(expected, actual);
        }
    }
}
