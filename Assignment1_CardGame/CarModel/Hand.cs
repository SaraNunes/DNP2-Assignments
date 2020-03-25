using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1_CardGame.CarModel
{
    public class Hand
    {
        public IEnumerable<Car> Cars { get; set; } = new List<Car>();

        public IEnumerable<Car> FindCarsByMaxSpeed(int speed)
        {
            return Cars.Where(car => car.MaxSpeed > speed);
        }
    }
}
