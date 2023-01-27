namespace Task_20
{
    internal class Program
    {
        static void Main()
        {
            string num = System.Console.ReadLine();

            try
            {
                long converted = long.Parse(num);
                System.Console.WriteLine($"{converted} can fit in:");
                if (converted >= byte.MinValue && converted <= byte.MaxValue)
                {
                    System.Console.WriteLine("* byte");
                }

                if (converted >= sbyte.MinValue && converted <= sbyte.MaxValue)
                {
                    System.Console.WriteLine("* sbyte");
                }

                if (converted >= short.MinValue && converted <= short.MaxValue)
                {
                    System.Console.WriteLine("* short");
                }

                if (converted >= ushort.MinValue && converted <= ushort.MaxValue)
                {
                    System.Console.WriteLine("* ushort");
                }

                if (converted >= int.MinValue && converted <= int.MaxValue)
                {
                    System.Console.WriteLine("* int");
                }

                if (converted >= uint.MinValue && converted <= uint.MaxValue)
                {
                    System.Console.WriteLine("* uint");
                }

                if (converted >= long.MinValue && converted <= long.MaxValue)
                {
                    System.Console.WriteLine("* long");
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine($"{num} can't fit in any type.");
            }
        }
    }
}