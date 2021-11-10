using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList20
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(2);
            list.Add("Adaś");
            list.Add(new Car("BMW"));
            list.Add("Bartuś");

            //Console.WriteLine(list[list.Count -1]);
            //Console.WriteLine(list[2]); // wyświetla prawidłowo BMW z klasy, ponieważ klasa
                                        // została przeciążona za pomocą metody overrise string ToString()


            //list.RemoveAt(1); // Method to delete one item in array. !!! as U can see all indexes decrement numbers
            //Console.WriteLine(list.Count);
            //list.Reverse();

            list.Insert(2, "Ala");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
