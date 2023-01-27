namespace Task_7
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
            long years = Math.Abs(closest / 128);
            if (closest % 128 != 0) years += 1;
            if (years == 1)
            {
                System.Console.WriteLine($"Prisoner with id {closest} is sentenced to {years} year.");
            }
            else
            {
                System.Console.WriteLine($"Prisoner with id {closest} is sentenced to {years} year.");
            }
            System.Console.WriteLine(years);
        }
    }
}