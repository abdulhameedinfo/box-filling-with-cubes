using BoxFillingWithCubes.Models;
using BoxFillingWithCubes.Utils;

namespace BoxFillingWithCubes.Services
{
    public class BoxFillingService: IBoxFillingService
    {
        public int CalculateMinimumCubes(Box box, CubeSet cubes)
        {
            int volumeRemaining = box.Volume;
            int totalCubesUsed = 0;

            // Iterate from largest cube size downwards
            for (int i = cubes.Quantities.Length - 1; i >= 0; i--)
            {
                int cubeSize = CalculationHelper.GetCubeSize(i);
                int cubeVolume = CalculationHelper.CalculateBoxVolume(cubeSize, cubeSize, cubeSize);

                int maxFit = CalculationHelper.CalculateRequiredCubes(volumeRemaining, cubeVolume);
                int cubesToUse = Math.Min(maxFit, cubes.Quantities[i]);

                totalCubesUsed += cubesToUse;
                volumeRemaining -= cubesToUse * cubeVolume;

                if (volumeRemaining == 0)
                    return totalCubesUsed;
            }

            return -1; // Unable to fill the box exactly
        }
    }
}
