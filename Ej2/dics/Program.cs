using System;
using System.Collections;
using System.IO;

namespace dics
{
    class Program
    {
        static void Main(string[] args)
        {
            //==========================This is a Dictionary=======================

            //var dic = new Dictionary<int,string>();
            //dic.Add(1,"a");
            //dic.Add(2,"b");
            //dic.Add(3,"c");
            //foreach (var number in dic)
            //{
            //    Console.WriteLine($"{number}");

            //}
            //string res;
            //dic.TryGetValue(6,out res);
            //Console.WriteLine($"{res}");


            //==========================This is a hashTable=======================

            //var hastable = new Hashtable();
            //hastable.Add(2, "esto es un value");
            //hastable.Add("esto es una key", 2);
            //Console.WriteLine();
            //Console.ReadLine();

            //==========================Write and Read file=======================


            string[] lines = { "First line\n", "Second line\n", "Third line\n\0" };
            using (var writer = File.CreateText("newfile.txt"))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }

            }
            using (var reader = new StreamReader("newfile.txt"))
            {
                foreach (char line in reader.ReadToEnd())
                {
                    Console.Write($"{line}");
                }

            }
            using (var reader = new StreamReader("newfile.txt"))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    Console.Write($"{linea}");
                }
            }
            Console.ReadLine();
            var file2 = new StreamWriter("newfiel.txt");
            file2.Close();
            file2.Write("a");


        }
    }
}

