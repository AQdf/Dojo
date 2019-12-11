using Sho.Dojo.Katas;
using System.Collections;
using Xunit;

namespace Sho.Dojo.Tests
{
    public class HelpYourGrannyTest
    {
        [Fact]
        public void NoFriendsTest()
        {
            string[] arrFriends = null;
            string[][] ftwns = null;
            Hashtable h = null;

            Assert.Equal(-1, HelpYourGranny.tour(arrFriends, ftwns, h));
        }

        [Fact]
        public void SampleTest()
        {
            string[] arrFriends = new string[] { "A1", "A2", "A3", "A4", "A5" };
            string[][] ftwns = new string[][] {
                new string[] { "A1", "X1" }, new string[] { "A2", "X2" }, new string[] { "A3", "X3" }, new string[] { "A4", "X4" }
            };
            Hashtable h = new Hashtable { { "X1", 100.0 }, { "X2", 200.0 }, { "X3", 250.0 }, { "X4", 300.0 } };

            Assert.Equal(889, HelpYourGranny.tour(arrFriends, ftwns, h));
        }

        [Fact]
        public void FewFriendsTourTest()
        {
            string[] arrFriends = new string[] { "Vova", "Taras", "Maryan" };
            string[][] ftwns = new string[][] {
                new string[] { "Vova", "Zazavoda" },
                new string[] { "Taras", "Zavoda" },
                new string[] { "Maryan", "Centr" } 
            };

            Hashtable h = new Hashtable
            {
                { "Zazavoda", 200.0 },
                { "Zavoda", 100.0 },
                { "Centr", 100.0 },
            };

            Assert.Equal(473, HelpYourGranny.tour(arrFriends, ftwns, h));
        }

        [Fact]
        public void NoTownOfFriendTourTest()
        {
            string[] arrFriends = new string[] { "Vova", "Taras", "Maryan" };
            string[][] ftwns = new string[][] {
                new string[] { "Vova", "Zazavoda" },
                new string[] { "Taras", "Zavoda" }
            };

            Hashtable h = new Hashtable
            {
                { "Zazavoda", 200.0 },
                { "Zavoda", 100.0 },
                { "Centr", 100.0 },
            };

            Assert.Equal(473, HelpYourGranny.tour(arrFriends, ftwns, h));
        }

        [Fact]
        public void NoTownOfFirstFriendTourTest()
        {
            string[] arrFriends = new string[] { "Vova", "Taras", "Maryan" };
            string[][] ftwns = new string[][] {
                new string[] { "Taras", "Zavoda" },
                new string[] { "Maryan", "Centr" }
            };

            Hashtable h = new Hashtable
            {
                { "Zazavoda", 200.0 },
                { "Zavoda", 100.0 },
                { "Centr", 100.0 },
            };

            Assert.Equal(200, HelpYourGranny.tour(arrFriends, ftwns, h));
        }
    }
}
