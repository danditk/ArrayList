using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList20
{
    class Car
    {

        public string Brand { get; set; }
        /// <summary>
        /// Tworzenie obiektu samochód
        /// </summary>
        /// <param name="brand">Marka samochodu</param>
        public Car(string brand)
        {
            Brand = brand;
        }
        public override string ToString()
        {
            return Brand;
        }
    }
}
