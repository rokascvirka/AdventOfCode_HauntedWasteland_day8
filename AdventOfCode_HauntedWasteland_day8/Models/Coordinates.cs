using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_HauntedWasteland_day8.Models
{
    public class Coordinates
    {
        public string MainCoordinate {  get; set; }
        public string LeftCord { get; set; }
        public string RightCord { get; set; }

        public Coordinates()
        {
            
        }

        public Coordinates(string coordinate, string left, string right)
        {
            MainCoordinate = coordinate;
            LeftCord = left;    
            RightCord = right;
        }
    }
}
