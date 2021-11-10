using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList list = new System.Collections.ArrayList();
            list.Add(2);
            list.Add("Adaś");
            list.Add(new Car("BMW"));

            Console.WriteLine(list.Count);

            Console.ReadKey();
        }
    }
}
