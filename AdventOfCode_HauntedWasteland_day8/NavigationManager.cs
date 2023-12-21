using AdventOfCode_HauntedWasteland_day8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_HauntedWasteland_day8
{
    public class NavigationManager
    {
        public static int CountSteps(Map map)
        {

            var steps = 0;
            var startingCord = map.Coordinates.FirstOrDefault(x => x.MainCoordinate == "AAA");
            var next = startingCord.MainCoordinate;
            bool isFound = false;

            while (!isFound)
            {
                foreach (var direction in map.Directions)
                {

                    var currentCorrdinate = FindNextCoordinate(map, next, direction);
                    next = currentCorrdinate.MainCoordinate;
                    steps++;
                    if(next == "ZZZ")
                    {
                        isFound = true;
                        break;
                    }
                }
            }
            return steps;
        }

        public static Coordinates FindNextCoordinate(Map map, string mainCord, char direction)
        {
            var shouldFind = "";
            var currentCoordinate = map.Coordinates.FirstOrDefault(x => x.MainCoordinate == mainCord);
            if (direction == 'L')
            {
                shouldFind = currentCoordinate.LeftCord;
            }
            if(direction == 'R')
            {
                shouldFind = currentCoordinate.RightCord;
            }

            var nextCoordinate = map.Coordinates.FirstOrDefault(x => x.MainCoordinate == shouldFind);
            return nextCoordinate;
        }
    }
}
