using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_scrabble_challenge.Main
{
    internal class Points
    {

        public Dictionary<string, int> PointsDict = new Dictionary<string, int>();
        

        public Points() {
            PointsDict.Add("A", 1);
            PointsDict.Add("E", 1);
            PointsDict.Add("I", 1);
            PointsDict.Add("L", 1);
            PointsDict.Add("N", 1);
            PointsDict.Add("O", 1);
            PointsDict.Add("R", 1);
            PointsDict.Add("S", 1);
            PointsDict.Add("T", 1);
            PointsDict.Add("U", 1);

            PointsDict.Add("D", 2);
            PointsDict.Add("G", 2);

            PointsDict.Add("B", 3);
            PointsDict.Add("C", 3);
            PointsDict.Add("M", 3);
            PointsDict.Add("P", 3);

            PointsDict.Add("F", 4);
            PointsDict.Add("H", 4);
            PointsDict.Add("V", 4);
            PointsDict.Add("W", 4);
            PointsDict.Add("Y", 4);

            PointsDict.Add("K", 5);

            PointsDict.Add("J", 8);
            PointsDict.Add("X", 8);

            PointsDict.Add("Q", 10);
            PointsDict.Add("Z", 10);
        }
    }
}
