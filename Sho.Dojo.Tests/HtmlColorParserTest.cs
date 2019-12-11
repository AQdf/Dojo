using Sho.Dojo.Katas;
using System.Collections.Generic;
using System.Drawing;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class HtmlColorParserTest
    {
        private static readonly Dictionary<string, string> _presetColors = new Dictionary<string, string>
        {
            { Color.AliceBlue.Name.ToLowerInvariant(), "#f0f8ff" },
            { "darkgrey" , "#a9a9a9" }
        };

        private readonly HtmlColorParser _htmlColorParser = new HtmlColorParser(_presetColors);

        [Theory]
        [InlineData("LimeGreen", 50, 205, 50)]
        [InlineData("dArKgrey", 169, 169, 169)]
        [InlineData("#80FFA0", 128, 255, 160)]
        [InlineData("#3B7", 51, 187, 119)]
        public void Test(string color, byte r, byte g, byte b)
        {
            Assert.Equal(new RGB(r, g, b), _htmlColorParser.Parse(color));
        }
    }
}
