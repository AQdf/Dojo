using System.Collections.Generic;
using System.Drawing;

namespace Sho.Dojo.Katas
{
    public class HtmlColorParser
    {
        private readonly IDictionary<string, string> presetColors;

        public HtmlColorParser(IDictionary<string, string> presetColors)
        {
            this.presetColors = presetColors;
        }

        public RGB Parse(string color)
        {
            //Color parsed = ColorTranslator.FromHtml(color);
            string colorHex = GetColorFormattedHex(color);
            ColorConverter converter = new ColorConverter();

            if (converter.IsValid(colorHex))
            {
                Color parsed = (Color)converter.ConvertFromString(colorHex);
                return new RGB(parsed.R, parsed.G, parsed.B);
            }

            throw new System.Exception($"Can't parse color '{color}'");
        }

        private string GetColorFormattedHex(string color)
        {
            string formatted = color.ToLowerInvariant();

            if (color.Length == 4 && color[0] == '#')
            {
                formatted = $"#{color[1]}{color[1]}{color[2]}{color[2]}{color[3]}{color[3]}";
            }
            else if (presetColors.ContainsKey(formatted))
            {
                formatted = presetColors[formatted];
            }

            return formatted;
        }
    }

    public struct RGB
    {
        public byte r, g, b;

        public RGB(byte r, byte g, byte b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }
}

/* Parse HTML/CSS Colors
In this kata you parse RGB colors represented by strings. The formats are primarily used in HTML and CSS.
Your task is to implement a function which takes a color as a string and returns the parsed color as a map (see Examples).
Input: The input string represents one of the following:
6-digit hexadecimal - "#RRGGBB" e.g. "#012345", "#789abc", "#FFA077"
Each pair of digits represents a value of the channel in hexadecimal: 00 to FF
3-digit hexadecimal - "#RGB" e.g. "#012", "#aaa", "#F5A"
Each digit represents a value 0 to F which translates to 2-digit hexadecimal: 0->00, 1->11, 2->22, and so on.
Preset color name e.g. "red", "BLUE", "LimeGreen"
You have to use the predefined map PRESET_COLORS (JavaScript, Python, Ruby), presetColors (Java, C#, Haskell), or preset-colors (Clojure).
The keys are the names of preset colors in lower-case and the values are the corresponding colors in 6-digit hexadecimal (same as 1. "#RRGGBB").
Examples:
Parse("#80FFA0")   === new RGB(128, 255, 160))
Parse("#3B7")      === new RGB( 51, 187, 119))
Parse("LimeGreen") === new RGB( 50, 205,  50))

// RGB struct is defined as follows:
struct RGB
{
    public byte r, g, b;
    public RGB(byte r, byte g, byte b);
}
*/
