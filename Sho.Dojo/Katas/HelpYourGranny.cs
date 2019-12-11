using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sho.Dojo.Katas
{
    public class HelpYourGranny
    {
        public static int tour(string[] arrFriends, string[][] ftwns, Hashtable h)
        {
            if (arrFriends == null || arrFriends.Length == 0)
            {
                return -1;
            }

            List<Connection> route = BuildRoute(arrFriends, ftwns);
            double distance = route.Sum(c => CalculateConnectionDistance(c, h));

            return (int)Math.Truncate(distance);
        }

        private static List<Connection> BuildRoute(string[] arrFriends, string[][] ftwns)
        {
            var result = new List<Connection>();
            string currentTown = null;

            foreach (string friend in arrFriends)
            {
                var nextTown = ftwns.FirstOrDefault(ft => ft[0] == friend);

                if (nextTown != null)
                {
                    result.Add(new Connection(currentTown, nextTown[1]));
                    currentTown = nextTown[1];
                }
                else
                {
                    if (currentTown != null)
                    {
                        result.Add(new Connection(currentTown, null));
                        currentTown = null;
                    }
                }
            }

            if (currentTown != null)
            {
                result.Add(new Connection(currentTown, null));
            }

            return result;
        }

        private static double CalculateConnectionDistance(Connection connection, Hashtable h)
        {
            if (connection.Start == null)
            {
                return (double)h[connection.End];
            }

            if (connection.End == null)
            {
                return (double)h[connection.Start];
            }

            double distanceFromStartToHome = (double)h[connection.Start];
            double distanceFromEndToHome = (double)h[connection.End];

            return Math.Sqrt(Math.Abs(distanceFromStartToHome*distanceFromStartToHome - distanceFromEndToHome* distanceFromEndToHome));
        }

        private class Connection
        {
            public Connection(string start, string end)
            {
                Start = start;
                End = end;
            }

            public string Start { get; set; }

            public string End { get; set; }
        }
    }
}

/* Help your granny!
Your granny, who lives in town X0, has friends. These friends are given in an array, for example: array of friends is
[ "A1", "A2", "A3", "A4", "A5" ].
The order of friends in this array must not be changed since this order gives the order in which they will be visited.
These friends inhabit towns and you have an array with friends and towns, for example:
[ ["A1", "X1"], ["A2", "X2"], ["A3", "X3"], ["A4", "X4"] ]
or
[ ("A1", "X1"), ("A2", "X2"), ("A3", "X3"), ("A4", "X4") ]
or
(C)
{"A1", "X1", "A2", "X2", "A3", "X3", "A4", "X4"}
which means A1 is in town X1, A2 in town X2... It can happen that we don't know the town of one of the friends.
Your granny wants to visit her friends and to know how many miles she will have to travel.
You will make the circuit that permits her to visit her friends. For example here the circuit will contain:
X0, X1, X2, X3, X4, X0 
and you must compute the total distance
X0X1 + X1X2 + .. + X4X0.
For the distance, fortunately, you have a map (and a hashmap) that gives each distance X0X1, X0X2 and so on. For example:
[ ["X1", 100.0], ["X2", 200.0], ["X3", 250.0], ["X4", 300.0] ]
or
Map("X1" -> 100.0, "X2" -> 200.0, "X3" -> 250.0, "X4" -> 300.0)
or (Coffeescript, Javascript)
['X1',100.0, 'X2',200.0, 'X3',250.0, 'X4',300.0 ]
or
(C)
{"X1", "100.0", "X2", "200.0", "X3", "250.0", "X4", "300.0"}
which means that X1 is at 100.0 miles from X0, X2 at 200.0 miles from X0, etc...
More fortunately (it's not real life, it's a story...), the towns X0, X1, ..Xn are placed in the following manner:
X0X1X2 is a right triangle with the right angle in X1, X0X2X3 is a right triangle with the right angle in X2, etc...
If a town Xi is not visited you will suppose that the triangle
X0Xi-1Xi+1 is still a right triangle.
(Ref: https://en.wikipedia.org/wiki/Pythagoras#Pythagorean_theorem)

Task
Can you help your granny and give her the distance to travel?

Notes
If you have some difficulty to see the tour I made a non terrific but maybe useful drawing:

All languages
See the data type of the parameters in the examples test cases.
Towns can have other names that X0, X1, X2, ... Xn
"tour" returns an int which is the floor of the total distance.
*/
