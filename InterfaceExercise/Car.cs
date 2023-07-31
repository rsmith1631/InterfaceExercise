using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
            CarCount++;
        }

        public string Name { get; set; }
        public int Wheels { get; set; } = 4;
        public int Seats { get; set; } = 5;

        public string DoorOpen { get; set; }
        public bool Electric { get; set; }
        public int MPG { get; set; }
        public string Country { get; set; } = "Japan";
        public string CompanyName { get; set; } = "Toyota";
        public static int CarCount { get; set; }

        public void Reverse()
        {
            Console.WriteLine("This car is reversing.");
        }

        public void TurnKey()
        {
            Console.WriteLine("Before you begin to drive... Please buckle your seat belt!");
        }
    }
}
