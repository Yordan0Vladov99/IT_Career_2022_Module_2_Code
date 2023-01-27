namespace Task_12
{
    internal class Program
    {
        static void Main()
        {

            int n = int.Parse(System.Console.ReadLine());
            double max = 0;
            string max_model = "";
            for (int i = 0; i < n; i++)
            {
                string model = System.Console.ReadLine();
                double radius = double.Parse(System.Console.ReadLine());
                int height = int.Parse(System.Console.ReadLine());
                double area = Math.PI * radius * height;
                if (area > max)
                {
                    max = area;
                    max_model = model;
                }
            }
            System.Console.WriteLine(max_model);


        }
    }
}