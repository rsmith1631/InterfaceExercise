using System;
using System.Collections.Generic;
using System.Dynamic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */
            Console.WriteLine("I would like to know your name for future greetings.");
            Console.Write("What is your name?: ");
            var driverName = Console.ReadLine();
            Console.WriteLine();
            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var corolla = new Car();
            corolla.Name = "Corolla";
            corolla.Electric = true;
            corolla.MPG = 38;
            corolla.DoorOpen = $"Welcome {driverName}. Enjoy your ride!";


            var camry = new Car();
            camry.Name = "Camry";
            camry.Electric = false;
            camry.MPG = 27;
            camry.DoorOpen = $"Welcome {driverName}. Enjoy your ride!";


            Truck ranger = new Truck();
            ranger.Name = "Ranger";
            ranger.Seats = 5;
            ranger.UtilityRack = true;
            ranger.DoorOpen = $"Welcome {driverName}. Enjoy your ride!";


            Truck f150 = new Truck();
            f150.Name = "F-150";
            f150.Seats = 6;
            f150.UtilityRack = false;
            f150.DoorOpen = $"Welcome {driverName}. Enjoy your ride!";


            SUV crv = new SUV();
            crv.Name = "CRV";
            crv.CargoSpace = "87.8 cubit ft.";
            crv.DoorOpen = $"Welcome {driverName}. Enjoy your ride!";

            var pilot = new SUV();
            pilot.Name = "Pilot";
            pilot.CargoSpace = "85.3 cubit ft.";
            pilot.DoorOpen = $"Welcome {driverName}. Enjoy your ride!";

            var vehicles = new List<IVehicle>();
            vehicles.Add(corolla);
            vehicles.Add(camry);
            vehicles.Add(ranger);
            vehicles.Add(f150);
            vehicles.Add(crv);
            vehicles.Add(pilot);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.Name);
                Console.WriteLine(vehicle.DoorOpen);
                vehicle.TurnKey();
                vehicle.Reverse();
                Console.WriteLine("");
                Console.WriteLine("--------------------------------------------------");
            }


        }
    }
}
