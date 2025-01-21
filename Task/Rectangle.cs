
namespace Task
{
    internal class Rectangle : IRectangle
    {
        public double Length { get ; set; }
        public double Width { get ; set ; }

        public double Area { get { return Length * Width; } }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Length = {Length}, Width = {Width}, Area = {Area}");
        }
    }
}
