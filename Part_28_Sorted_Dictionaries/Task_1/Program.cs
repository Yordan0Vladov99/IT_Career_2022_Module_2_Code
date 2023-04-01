using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        var floatCount = new Dictionary<string, int>();
        string[] floats = input.Split(' ');

        foreach (string floatStr in floats)
        {
            if (!floatCount.ContainsKey(floatStr))
            {
                floatCount.Add(floatStr, 1);
            }
            else
            {
                int counts = floatCount[floatStr];
                floatCount[floatStr] = counts + 1;
            }
        }

        var countList = floatCount.ToList();
        countList.Sort((a, b) => b.Value.CompareTo(a.Value));

        foreach (KeyValuePair<string, int> elem in countList)
        {
            Console.WriteLine($"{elem.Key} -> {elem.Value}");
        }
    }
}
