using System.Reflection;

namespace AdventOfCode_HauntedWasteland_day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var FILE_PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? "", "InputDay8.txt");

            var data = FileReader.ReadFile(FILE_PATH);

            var steps = NavigationManager.CountSteps(data);

            Console.WriteLine($"Steps: {steps}");
        }
    }
}