using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
            SUVCount++;
        }
        public string Name { get; set; }
        public int Wheels { get; set; } = 4;
        public int Seats { get; set; } = 5;

        public string DoorOpen { get; set; }
        public static bool RoofRack { get; set; } = false;
        public string CargoSpace { get; set; }
        public string CompanyName { get; set; } = "Honda";
        public string Country { get; set; } = "Japan";
        public static int SUVCount { get; set; }

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
