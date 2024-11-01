using BoxFillingWithCubes.Models;

public interface IBoxFillingService
{
    int CalculateMinimumCubes(Box box, CubeSet cubeSet);
}