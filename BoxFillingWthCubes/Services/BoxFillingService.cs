using BoxFillingWithCubes.Models;

namespace BoxFillingWithCubes.Services
{
    public static class BoxFillingService
    {
        public static int CalculateMinimumCubes(Box box, CubeSet cubes)
        {
            int volumeRemaining = box.Volume;
            int totalCubesUsed = 0;

            // Iterate from largest cube size downwards
            for (int i = cubes.Quantities.Length - 1; i >= 0; i--)
            {
                int cubeSize = (int)Math.Pow(2, i);
                int cubeVolume = cubeSize * cubeSize * cubeSize;

                int maxFit = volumeRemaining / cubeVolume;
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
