using BoxFillingWithCubes.Models;

namespace BoxFillingWithCubes.Utils
{
    public static class InputParser
    {
        public static (Box, CubeSet) ParseLine(string line)
        {
            var parts = line.Trim().Split(' ').Select(int.Parse).ToArray();
            var box = new Box(parts[0], parts[1], parts[2]);
            var cubes = new CubeSet(parts.Skip(3).ToArray());
            return (box, cubes);
        }
    }
}
