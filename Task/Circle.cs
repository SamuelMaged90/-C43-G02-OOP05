
namespace Task
{
    internal class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Area
        {
            get
            {
                return Radius * Radius * Math.PI;
            }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area}");
        }
    }
}
