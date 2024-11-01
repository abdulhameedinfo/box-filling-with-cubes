public class BoxFillingApp
{
    private readonly IBoxFillingService _boxFillingService;
    private readonly IInputParser _inputParser;

    public BoxFillingApp(IBoxFillingService boxFillingService, IInputParser inputParser)
    {
        _boxFillingService = boxFillingService;
        _inputParser = inputParser;
    }

    public void Run(string[] args)
    {
        var filePath = "../BoxFillingWthCubes/Input/problem.txt";
        var inputLines = File.ReadAllLines(filePath);

        foreach (var line in inputLines)
        {
            var (box, cubes) = _inputParser.ParseLine(line);
            var result = _boxFillingService.CalculateMinimumCubes(box, cubes);
            Console.WriteLine(result);
        }
    }
}
