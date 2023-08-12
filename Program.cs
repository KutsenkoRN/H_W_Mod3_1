using System;
using System.Collections.Generic;
using System.Linq;
using H_W_Mod3_1;

namespace H_W_Mod3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<Person> list = new MyList<Person>();
            list.Add(new Person(1, "Tom"));
            list.Add(new Person(4, "Bob"));
            list.Add(new Person(3, "Mike"));
            list.Add(new Person(2, "Jacob"));
            list.Add(new Person(5, "Alexander"));


            Console.WriteLine("Length:" + list.Count());

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("==============================");
            
            list.Sort();
            foreach (var i in list)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("==============================");

            list.SetDefaultAt(3);
            foreach (var i in list)
            {
                if (i != null)
                {
                    Console.WriteLine(i.ToString());
                }
                
            }

        }
    }

}