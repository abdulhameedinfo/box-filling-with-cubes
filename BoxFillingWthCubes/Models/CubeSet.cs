namespace BoxFillingWithCubes.Models
{
    public class CubeSet
    {
        public int[] Quantities { get; set; }

        public CubeSet(int[] quantities)
        {
            Quantities = quantities;
        }
    }
}
