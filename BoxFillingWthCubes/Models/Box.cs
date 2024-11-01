namespace BoxFillingWithCubes.Models
{
    public class Box
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Box(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public int Volume => Length * Width * Height;
    }
}
