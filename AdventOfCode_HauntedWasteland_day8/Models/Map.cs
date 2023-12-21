using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_HauntedWasteland_day8.Models
{
    public class Map
    {
        public char[] Directions { get; set; }
        public List<Coordinates> Coordinates{ get; set; }
    }
}
