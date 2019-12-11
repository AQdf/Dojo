namespace Sho.Dojo.Katas
{
    public class ClockInMirror
    {
        public static string WhatIsTheTime(string timeInMirror)
        {
            int mirrorHours = int.Parse(timeInMirror.Substring(0, 2));
            int mirrorMinutes = int.Parse(timeInMirror.Substring(3, 2));

            int actualMinutes = mirrorMinutes != 0 ? 60 - mirrorMinutes : 0;
            int actualHours = mirrorMinutes != 0 ? 11 - mirrorHours : 12 - mirrorHours;

            if (actualHours <= 0)
            {
                actualHours = 12 - System.Math.Abs(actualHours);
            }

            return $"{actualHours:00}:{actualMinutes:00}";

            // Best solution
            // return DateTime.Parse("12:00").Subtract(TimeSpan.Parse(timeInMirror)).ToString("hh:mm");
        }
    }
}

/* Clock in Mirror
Peter can see a clock in the mirror from the place he sits in the office. When he saw the clock shows 12:22
He knows that the time is 11:38
in the same manner:
05:25 --> 06:35
01:50 --> 10:10
11:58 --> 12:02
12:01 --> 11:59
Please complete the function WhatIsTheTime(timeInMirror), where timeInMirror is the mirrored time (what Peter sees) as string.
Return the real time as a string.
Consider hours to be between 1 <= hour < 13.
So there is no 00:20, instead it is 12:20.
There is no 13:20, instead it is 01:20.
*/
