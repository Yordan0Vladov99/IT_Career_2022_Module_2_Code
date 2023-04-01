namespace Task_3
{
    internal class Program
    {
        static void Main()
        {
            int prices = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            int price = int.Parse(Console.ReadLine());

            for (int i = 1; i < prices; i++)
            {
                int new_price = int.Parse(Console.ReadLine());
                double diff = 0;

                diff = (double)Math.Abs(price - new_price) / price;



                if (price == new_price)
                {
                    Console.WriteLine($"NO CHANGE: {new_price}");
                }
                else if (diff <= threshold)
                {

                    Console.WriteLine($"MINOR CHANGE: {price} to {new_price} ({diff * 100:f2}%)");
                }
                else if (new_price > price)
                {
                    Console.WriteLine($"PRICE UP: {price} to {new_price} ({diff * 100:f2}%)");
                }
                else
                {
                    Console.WriteLine($"PRICE DOWN: {price} to {new_price} ({diff * 100:f2}%)");
                }
                price = new_price;
            }
        }
    }
}