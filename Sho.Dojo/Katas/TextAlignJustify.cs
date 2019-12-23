using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sho.Dojo.Katas
{
    public class TextAlignJustify
    {
        //public static string Justify(string str, int len)
        //{
        //    if (string.IsNullOrWhiteSpace(str))
        //    {
        //        return string.Empty;
        //    }

        //    string[] words = str.Split(' ');
        //    List<string> lines = new List<string>();
        //    StringBuilder lineBuilder = new StringBuilder();

        //    for (int i = 0; i < words.Length; i++)
        //    {
        //        if ((lineBuilder.Length + words[i].Length) < len)
        //        {
        //            string strToAppend = lineBuilder.Length == 0 ? words[i] : $" {words[i]}";
        //            lineBuilder.Append(strToAppend);
        //        }
        //        else
        //        {
        //            if (lineBuilder.Length != 0)
        //            {
        //                lines.Add(JustifyLine(lineBuilder.ToString(), len));
        //                lineBuilder.Clear();
        //            }

        //            lineBuilder.Append(words[i]);
        //        }
        //    }

        //    lines.Add(lineBuilder.ToString());

        //    return string.Join("\n", lines);
        //}

        public static string Justify(string str, int len)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return string.Empty;
            }

            string[] words = str.Split(' ');
            List<string> lines = new List<string>();
            StringBuilder lineBuilder = new StringBuilder();

            foreach (string word in words)
            {
                if ((lineBuilder.Length + word.Length) < len)
                {
                    string strToAppend = lineBuilder.Length == 0 ? word : $" {word}";
                    lineBuilder.Append(strToAppend);
                }
                else
                {
                    lines.Add(JustifyLine(lineBuilder.ToString(), len));
                    lineBuilder.Clear();
                    lineBuilder.Append(word);
                }
            }

            lines.Add(lineBuilder.ToString());

            return string.Join("\n", lines);
        }

        private static string JustifyLine(string line, int len)
        {
            if (!line.Contains(" "))
            {
                return line;
            }

            int index = 0;
            string searchString = " ";

            while (line.Length != len)
            {
                index = line.IndexOf(searchString, index);

                if (index != -1)
                {
                    line = line.Insert(index, " ");
                    index +=2;
                }
                else
                {
                    index = 0;
                    searchString += " ";
                }
            }

            return line;
        }
    }
}

/* Text align justify
Your task in this Kata is to emulate text justification in monospace font.
You will be given a single-lined text and the expected justification width.
The longest word will never be greater than this width.

Here are the rules:

Use spaces to fill in the gaps between words.
Each line should contain as many words as possible.
Use '\n' to separate lines.
Gap between words can't differ by more than one space.
Lines should end with a word not a space.
'\n' is not included in the length of a line.
Large gaps go first, then smaller ones ('Lorem--ipsum--dolor--sit-amet,' (2, 2, 2, 1 spaces)).
Last line should not be justified, use only one space between words.
Last line should not contain '\n'
Strings with one word do not need gaps ('somelongword\n').
Example with width=30:

Lorem  ipsum  dolor  sit amet,
consectetur  adipiscing  elit.
Vestibulum    sagittis   dolor
mauris,  at  elementum  ligula
tempor  eget.  In quis rhoncus
nunc,  at  aliquet orci. Fusce
at   dolor   sit   amet  felis
suscipit   tristique.   Nam  a
imperdiet   tellus.  Nulla  eu
vestibulum    urna.    Vivamus
tincidunt  suscipit  enim, nec
ultrices   nisi  volutpat  ac.
Maecenas   sit   amet  lacinia
arcu,  non dictum justo. Donec
sed  quam  vel  risus faucibus
euismod.  Suspendisse  rhoncus
rhoncus  felis  at  fermentum.
Donec lorem magna, ultricies a
nunc    sit    amet,   blandit
fringilla  nunc. In vestibulum
velit    ac    felis   rhoncus
pellentesque. Mauris at tellus
enim.  Aliquam eleifend tempus
dapibus. Pellentesque commodo,
nisi    sit   amet   hendrerit
fringilla,   ante  odio  porta
lacus,   ut   elementum  justo
nulla et dolor.

Also you can always take a look at how justification works in your text editor or directly in HTML (css: text-align: justify).
Have fun :)
 */
