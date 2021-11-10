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

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(1);



            //Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //dictionary.Add(1, "Wojnem i mieczem");
            //dictionary.Add(10, "Śmierzch");
            //dictionary.Add(4, "Harry z młotem");

            //if (!dictionary.ContainsKey(4)) // When we hawe thesame key we have to fhink about it and create exception!
            //    dictionary.Add(4, "!!!!!");

            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine("{0}. - {1}", item.Key, item.Value);
            //}

            //List<Car> carList = new List<Car>();
            //carList.Add(new Car("Mercedes"));
            //carList.Add(new Car("Seat"));

            //List<int> list = new List<int>();
            //list.Add(2);
            //list.Add(5);



            //ArrayList list = new ArrayList();
            //list.Add(2);
            //list.Add("Adaś");
            //list.Add(new Car("BMW"));
            //list.Add("Bartuś");

            //Console.WriteLine(list[list.Count -1]);
            //Console.WriteLine(list[2]); // wyświetla prawidłowo BMW z klasy, ponieważ klasa
            // została przeciążona za pomocą metody overrise string ToString()


            //list.RemoveAt(1); // Method to delete one item in array. !!! as U can see all indexes decrement numbers
            //Console.WriteLine(list.Count);
            //list.Reverse();

            //list.Insert(2, "Ala");

            //list.Clear(); 
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(list.Count);

            Console.ReadKey();
        }
    }
}
