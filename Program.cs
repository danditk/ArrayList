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
            Stack<string> stack = new Stack<string>();
            // Stos działa bardzo podobnie do kolejki, różni się tylko kolejnością (taki queue.Reverse() :D).
            stack.Push("Adam");
            stack.Push("Ewa");
            stack.Push("Abla");
            stack.Push("Kain");

            Console.WriteLine("{0} zabił {1}, i {2} powiedziała mężowi, który miał na imie {3}",
                stack.Pop(), stack.Pop(), stack.Pop(), stack.Pop());

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(7);
            //queue.Enqueue(7);

            ////Console.WriteLine(queue.Peek());
            ////Console.WriteLine(queue.Peek());

            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());

            //// ! You have to create some code fo exception - Console.WriteLine(queue.Dequeue()); w kolejce nie ma już żadnych elementów
            //if (queue.Count == 0)
            //    Console.WriteLine(queue.Dequeue());
            //else Console.WriteLine("Kolejka jest pusta");



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
