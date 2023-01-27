namespace Task_6
{
    internal class Program
    {
        static void Main()
        {
            string type = System.Console.ReadLine();
            int n = int.Parse(System.Console.ReadLine());
            long threshold = 0;
            switch (type)
            {
                case "sbyte":
                    threshold = sbyte.MaxValue;
                    break;

                case "int":
                    threshold = int.MaxValue;
                    break;

                case "long":
                    threshold = long.MaxValue;
                    break;
            }
            long dif = long.MaxValue;
            long closest = -1;
            for (int i = 0; i < n; i++)
            {
                long num = long.Parse(System.Console.ReadLine());
                if (Math.Abs(num) > threshold)
                {
                    continue;
                }
                long cur_dif = Math.Abs(num - threshold);
                if (cur_dif < dif)
                {
                    closest = num;
                    dif = cur_dif;
                }
            }

            System.Console.WriteLine(closest);
        }
    }
}