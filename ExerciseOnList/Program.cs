using System;
using System.Collections.Generic;

class ExerciseOnList
{
    static public void Main()
    {
        List<int> num_list = new List<int> { 75, 34 };
        num_list.Add(100);
        num_list.AddRange(new int[] { 68, 20, 10, 99 });

        Console.WriteLine("Unsorted List:");
        foreach (int a in num_list)
        {
            Console.WriteLine(a);
        }

        num_list.Sort();
        Console.WriteLine("Sorted List:");
        foreach (int a in num_list)
        {
            Console.WriteLine(a);
        }
        Console.Write("Total count of numbers:");
        Console.WriteLine(num_list.Count);

        num_list.RemoveAt(3);
        num_list.Remove(100);
        Console.Write("count after removal:");
        Console.WriteLine(num_list.Count);
        foreach (int a in num_list)
        {
            Console.WriteLine(a);
        }
    }
}

