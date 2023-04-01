using System.Text;

namespace Task_5
{
    internal class Program
    {
        static void Main()
        {
            List<(int, int)> directions = new List<(int, int)>(){
                (1,0),
                (0,-1),
                (-1,0),
                (0,1)
            };
            int position = 0;
            (int, int) currentPos = (0, 0);
            String instructions = Console.ReadLine();
            StringBuilder distance = new StringBuilder();

            foreach (char c in instructions)
            {
                if (c >= '0' && c <= '9')
                {
                    distance.Append(c);
                }
                else
                {
                    if (distance.Length != 0)
                    {
                        int distanceVal = int.Parse(distance.ToString());
                        distance = new StringBuilder();
                        currentPos.Item1 += directions[position].Item1 * distanceVal;
                        currentPos.Item2 += directions[position].Item2 * distanceVal;
                    }
                    if (c == 'R')
                    {
                        position = ((position + 1) % 4 + 4) % 4;
                    }
                    else if (c == 'L')
                    {
                        position = ((position - 1) % 4 + 4) % 4;

                    }
                }
            }
            if (distance.Length != 0)
            {
                int distanceVal = int.Parse(distance.ToString());
                currentPos.Item1 += directions[position].Item1 * distanceVal;
                currentPos.Item2 += directions[position].Item2 * distanceVal;
            }

            double distanceTravelled = Math.Sqrt(Math.Pow(currentPos.Item1, 2) + Math.Pow(currentPos.Item2, 2));
            Console.WriteLine($"Position: (x: {currentPos.Item1}, y: {currentPos.Item2}), Distance = {distanceTravelled:f2}m");

        }
    }
}