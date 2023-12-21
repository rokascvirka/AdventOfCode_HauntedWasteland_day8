using AdventOfCode_HauntedWasteland_day8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_HauntedWasteland_day8
{
    public class FileReader
    {
        public static Map ReadFile(string path)
        {
            var map = new Map();
            var coordinates = new List<Coordinates>();
            using (StreamReader sr = new StreamReader(path))
            {
                var text = sr.ReadToEnd().Split(new string[] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                var directions = text[0].ToCharArray();
                map.Directions = directions;
                var instructions = text[1].Replace("=", "").Replace("(", "").Replace(")", "").Replace(",", "").Split(Environment.NewLine);
                foreach (var line in instructions)
                {
                    var instruction = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    var coordinate = instruction[0];
                    var leftCord = instruction[1];
                    var rightCord = instruction[2];    
                    coordinates.Add(new Coordinates(coordinate,leftCord, rightCord));
                }
            }

            map.Coordinates = coordinates;
            return map;
        }
    }
}
