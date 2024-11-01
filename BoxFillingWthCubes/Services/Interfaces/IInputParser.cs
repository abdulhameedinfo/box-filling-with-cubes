using BoxFillingWithCubes.Models;

public interface IInputParser
{
    (Box, CubeSet) ParseLine(string line);
}