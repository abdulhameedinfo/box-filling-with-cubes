namespace BoxFillingWithCubes.Utils
{
    public static class CalculationHelper
    {
        public static int CalculateBoxVolume(int length, int width, int height)
        {
            return length * width * height;
        }

        public static int GetCubeSize(int power)
        {
            // Returns cube side length as power of 2
            return (int)Math.Pow(2, power);
        }

        public static int CalculateRequiredCubes(int volumeRemaining, int cubeVolume)
        {
            // Returns the maximum number of cubes that can fit in the remaining volume
            return volumeRemaining / cubeVolume;
        }
    }
}
