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
        public int ProductionYear { get; set; }
        /// <summary>
        /// Tworzenie obiektu samochód
        /// </summary>
        /// <param name="brand">Marka samochodu</param>
        /// <param name="ProductionYear">Rocznik / data produkcji</param>
        public Car(string brand, int ProductionYear)
        {
            Brand = brand;
            this.ProductionYear = ProductionYear; // this odnosi się do tego obiektu - rodzica np. konstruktora,
                                                  // dlatego można użyć takiej samej nazwy zmiennej!
        }
        public override string ToString()
        {
            return Brand;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public bool Equals(Car car)
        {
            return car.Brand == this.Brand; // We can add here && or || to compare mor precisely
        }
    }
}
