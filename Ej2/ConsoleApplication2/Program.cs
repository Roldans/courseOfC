using System;
using System.Collections;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new int[20];

            var list2 = new ArrayList() { 2, 3 };
            list2.Add(2);
            list2.Add(3);

            for (int i = 0; i < 20; i++)
            {
                list[i] = i * 2;
                list2.Add(i * i);
            }

            foreach (var number in list)
            {
                Console.WriteLine($"{number}");
            }

            Console.WriteLine($"================================");

            foreach (var number in list2)
            {
                Console.WriteLine($"{number}");
                
            }

            Console.ReadLine(); 
        }
    }
}
