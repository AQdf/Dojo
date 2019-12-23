using Sho.Dojo.Katas;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class TextAlignJustifyTest
    {
        [Theory]
        [InlineData("", 2, "")]                             // Empty string test
        [InlineData("123 45 6", 7, "123  45\n6")]           // Sample test
        [InlineData("Lorem ipsum dolor sit", 15, "Lorem     ipsum\ndolor sit")]           // More than 2 spaces test
        [InlineData("at aliquet orci. Fusce at dolor sit amet fe", 15, "at      aliquet\norci.  Fusce at\ndolor  sit amet\nfe")]           // More than 2 spaces test
        [InlineData("ligula tempor eget. In quis rhoncus", 15, "ligula   tempor\neget.  In  quis\nrhoncus")]           // More than 2 spaces test
        [InlineData("Vestibulum sagittis dolor mauris, at elementum", 20, "Vestibulum  sagittis\ndolor   mauris,   at\nelementum")]           // More than 2 spaces test
        [InlineData("imperdiet tellus. Nulla eu vestibulum urna. Vivamus tincidunt suscipi", 25, "imperdiet  tellus.  Nulla\neu    vestibulum    urna.\nVivamus tincidunt suscipi")]           // More than 2 spaces test
        [InlineData("a b c d", 4, "a  b\nc d")]             // Use spaces to fill in the gaps between words.
        [InlineData("a b c d e f g", 13, "a b c d e f g")]  // Each line should contain as many words as possible.
        [InlineData("ab cd", 2, "ab\ncd")]                  // Use '\n' to separate lines.
        [InlineData("ab cd ef g", 9, "ab  cd ef\ng")]       // Gap between words can't differ by more than one space.
        [InlineData("a b c", 4, "a  b\nc")]                 // Lines should end with a word not a space.
        [InlineData("a b c", 1, "a\nb\nc")]                 // '\n' is not included in the length of a line.
        [InlineData("a b c d e", 6, "a  b c\nd e")]         // Last line should not be justified, use only one space between words.
        [InlineData("a b c d e f", 6, "a  b c\nd e f")]     // Last line should not contain '\n'
        [InlineData("abcdef ge", 7, "abcdef\nge")]          // Strings with one word do not need gaps('somelongword\n').
        public void Test(string str, int len, string expected)
        {
            Assert.Equal(expected, TextAlignJustify.Justify(str, len));
        }
    }
}
