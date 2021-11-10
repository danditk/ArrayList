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

            Console.WriteLine(list.Count);

            Console.ReadKey();
        }
    }
}
