using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10A
{
    internal class Car
    {
        public string Registration { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public CarTypes Type { get; set; }
        public double RentalCost { get; set; }

        public Car() { }

        public Car(string registration, int year, string make, string model, string color, CarTypes type, double rentalCost)
        {
            Registration = registration;
            Year = year;
            Make = make;
            Model = model;
            Color = color;
            Type = type;
            RentalCost = rentalCost;
        }

        public override string ToString()
        {
            return $"[{Registration} ({Year})] {Make} - {Model} ({RentalCost.ToString("C")})";
        }

    }


    enum CarTypes
    {
        SUV,
        Sedan,
        Hatchback,
        Coupe,
        Sports,
        Minivan,
        Ute,
    }

}
