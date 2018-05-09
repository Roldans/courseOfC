using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqs
{
    public class Persona : Object
    {
        public int id { get; set; }
        public string name { get; set; }

        public Persona(int id, string name)
        {
            this.id = id;
            this.name = name;

        }
        public Persona()
        {

        }
        public string toString()
        {
            return $"{this.id.ToString()}-{this.name}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var res = new List<String>();

            var list2 = new List<int>();
            for (int i = 0; i < 50; i++)
            {
                list2.Add(i * i);
            }
            var list3 = new List<String>
            {
                "Hola",
                "Mundo",
                "ayer",
                "mañana",
                "Pasado",
                "final",
                "comienzo",
                "first",
                "second",
                "third",
                "A",
                "B",
                "C"

            };



            //Console.WriteLine("===================================linq:===================================");
            ////Esto es una linq
            //var query = from str in list3 where str.Contains("a") select str;
            //foreach(string word in query)
            //{
            //    Console.WriteLine(word);

            //}
            //Console.WriteLine("===================================for:===================================");
            //foreach (string word in list3)
            //{
            //    if (word.Contains("a"))
            //    {
            //        res.Add(word);
            //    }
            //}

            ////foreach (string word in res)
            ////{
            ////    Console.WriteLine(word);

            ////}
            //Console.WriteLine("===================================linq2:===================================");
            //var query2 = from n in list3
            //            where n.Length > 2
            //            select n;
            //foreach (string word in query2)
            //{
            //    Console.WriteLine(word);

            //}

            //Console.WriteLine("===================================linq3:===================================");
            //var query3 = list3.Where(z => z.Length > 2);

            //foreach(string word in query3)
            //{
            //    Console.WriteLine(word);

            //}


            Console.WriteLine("===================================linq4:===================================");
            Persona persona1 = new Persona();
            persona1.id = 1;
            persona1.name = "name1";

            Persona persona2 = new Persona();
            persona2.id = 2;
            persona2.name = "name2";

            Persona persona3 = new Persona();
            persona3.id = 3;
            persona3.name = "name3";

            Persona persona4 = new Persona();
            persona4.id = 4;
            persona4.name = "name4";

            Persona persona5 = new Persona();
            persona5.id = 5;
            persona5.name = "name5";

            var gente = new List<Persona>
            {
                persona1,
                persona2,
                persona3,
                persona4,
                persona5,
                new Persona(6,"nome6"),
                new Persona(7,"nome7")
            };
            var query4 = gente.Where(z => z.id > 2);

            foreach (Persona persona in query4)
            {
                Console.WriteLine(persona.toString());

            }
            Console.WriteLine("===================================linq5:===================================");

            var query5 = gente.Where(z => z.name.Contains("a"));

            foreach (Persona persona in query5)
            {
                Console.WriteLine(persona.toString());

            }
            Console.ReadLine();
        }






    }
}
