namespace Task_6
{
    internal class Program
    {
        static double getTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = getTriangleArea(width, height);
            System.Console.WriteLine(area);
        }
    }
}