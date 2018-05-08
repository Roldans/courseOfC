using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
    class Program
    {
        static Dictionary<int, long> mem =
                    new Dictionary<int, long>();

        static long initrecurfib(int num)
        {
            long res=0;
            mem.Add(0, 1);
            mem.Add(1, 1);
            res=recurfib(num);
            foreach (long element in mem.Values)
            {
                System.Console.WriteLine(element);
            }
            return res;
        }
        static long recurfib(int num)
        {
            long res = 0;
            if (mem.ContainsKey(num))
            {
                mem.TryGetValue(num,out res);
            }
            else
            {
                res = recurfib(num-1) + recurfib(num-2);
                mem.Add(num, res);
            }
            return res;
        }
        static void iterfib(long num)
        {
            num = num + 1;

            var sol = new long[num];
            sol[0] = 1;
            sol[1] = 1;

            long aux = 2;
            long b = 1;
            long c = 2;

            for (int i = 2; i <= num-1; i++)
            {
                sol[i] = c;
                aux = c;
                c = c + b;
                b = aux;

            }
            foreach (long element in sol)
            {
                System.Console.WriteLine(element);
            }
        }
        static void Main(string[] args)
        {
            Program.iterfib(80);
            Console.WriteLine("============================================");
            Program.initrecurfib(80);
            Console.ReadLine();

        }
    }
}
