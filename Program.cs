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

            Console.WriteLine(list[list.Count -1]);

            Console.ReadKey();
        }
    }
}
