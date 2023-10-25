using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10B
{
    internal class Car
    {

        public string Registration { get; set; }
        public double RentalCost { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Seats { get; set; }
        public CarTypes CarType { get; set; }


        public Car() { }

        public Car(string registration, double rentalCost, string make, string model, int seats, CarTypes carType)
        {
            Registration = registration;
            RentalCost = rentalCost;
            Make = make;
            Model = model;
            Seats = seats;
            CarType = carType;
        }


        public override string ToString()
        {
            return $"[{Registration}] {Make} - {Model} ({RentalCost})";
        }


    }



    enum CarTypes
    {
        Hatchback,
        Ute,
        Sedan,
        SUV,
        Coupe,
        Minivan,
        Crossover,
        Sports,
    }

}
