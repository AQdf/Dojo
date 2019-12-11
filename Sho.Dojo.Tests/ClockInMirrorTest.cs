using Sho.Dojo.Katas;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class ClockInMirrorTest
    {
        [Theory]
        [InlineData("06:35", "05:25")]
        [InlineData("10:10", "01:50")]
        [InlineData("12:02", "11:58")]
        [InlineData("11:59", "12:01")]
        [InlineData("11:00", "01:00")] // Zero minutes in mirrored time
        [InlineData("12:00", "12:00")] // Start time
        [InlineData("01:15", "10:45")] // Before 06:00 o'clock
        public void Test(string timeInMirror, string expectedActualTime)
        {
            Assert.Equal(expectedActualTime, ClockInMirror.WhatIsTheTime(timeInMirror));
        }
    }
}
