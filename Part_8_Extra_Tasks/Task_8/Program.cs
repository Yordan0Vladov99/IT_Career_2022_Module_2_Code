namespace Task_8
{
    internal class Program
    {
        static void Main()
        {
            int a = int.Parse(System.Console.ReadLine());
            int b = int.Parse(System.Console.ReadLine());
            long s_price;
            long i_price;

            if (a >= -128 && a <= 127)
            {
                s_price = a;
                i_price = b;
            }
            else
            {
                s_price = b;
                i_price = a;
            }

            System.Console.WriteLine(i_price * 10 + s_price * 4);
        }
    }
}