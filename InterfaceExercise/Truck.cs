using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany

    { public Truck()
        {
            TruckCount++;
        }
        public string Name { get; set; }
        public int Wheels { get; set; } = 4;
        public int Seats { get; set; }

        public string DoorOpen { get; set; }
        public static bool TruckBed { get; set; } = true;
        public bool UtilityRack { get; set; }
        public string CompanyName { get; set; } = "Ford";
        public string Country { get; set; } = "United States";
        public static int TruckCount { get; set; }

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
