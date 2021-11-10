using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList20
{
    class Car
    {

        public string Brend { get; set; }
        /// <summary>
        /// Tworzenie obiektu samochód
        /// </summary>
        /// <param name="brend">Marka samochodu</param>
        public Car(string brend)
        {
            Brend = brend;
        }
    }
}
