using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1_CardGame.CarModel
{
    public class Car : IComparable<Car>
    {
        public string Model { get; set; }
        public double MaxSpeed { get; set; }
        public double HorsePower { get; set; }
        public int EngineSize { get; set; }
        public int RoundsPerMinute { get; set; }
        public double Acceleration { get; set; }
        public int Cylinders { get; set; }

        public int CompareTo(Car other)
        {
            if (ReferenceEquals(this, other))
            {
                return 0;
            }

            return other is null
                ? 1
                : MaxSpeed.CompareTo(other.MaxSpeed);
        }

        public int CompareToByHorsePower(Car other)
        {
            if (ReferenceEquals(this, other))
            {
                return 0;
            }

            return other is null
                ? 1
                : HorsePower.CompareTo(other.HorsePower);
        }

        public int CompareToByRoundsPerMinute(Car other)
        {
            if (ReferenceEquals(this, other))
            {
                return 0;
            }

            return other is null
                ? 1
                : RoundsPerMinute.CompareTo(other.RoundsPerMinute);
        }

        public int CompareToByEngineSize(Car other)
        {
            if (ReferenceEquals(this, other))
            {
                return 0;
            }

            return other is null
                ? 1
                : EngineSize.CompareTo(other.EngineSize);
        }

        public int CompareToByAcceleration(Car other)
        {
            if (ReferenceEquals(this, other))
            {
                return 0;
            }

            return other is null
                ? 1
                : Acceleration.CompareTo(other.Acceleration);
        }

        public int CompareToByCylinders(Car other)
        {
            if (ReferenceEquals(this, other))
            {
                return 0;
            }

            return other is null
                ? 1
                : Cylinders.CompareTo(other.Cylinders);
        }

        public override string ToString()
        {
            return $"Car [Model: {Model}, MaxSpeed: {MaxSpeed}, " +
                   $"HorsePower: {HorsePower}, EngineSize: {EngineSize}, RoundsPerMinute: {RoundsPerMinute}, " +
                   $"Acceleration: {Acceleration}, Cylinders: {Cylinders}]";
        }
    }
}