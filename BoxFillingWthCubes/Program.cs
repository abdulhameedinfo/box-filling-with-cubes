using BoxFillingWithCubes.Services;
using BoxFillingWithCubes.Utils;

public class Program
{
    public static void Main(string[] args)
    {
        var filePath = "..\\BoxFillingWthCubes\\Input\\problem.txt";
        var inputLines = File.ReadAllLines(filePath);

        foreach (var line in inputLines)
        {
            var (box, cubes) = InputParser.ParseLine(line);
            var result = BoxFillingService.CalculateMinimumCubes(box, cubes);
            Console.WriteLine(result);
        }
    }
}