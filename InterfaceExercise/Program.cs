using InterfaceExercise;
using System;
using System.Collections.Generic;
using System.IO;
//DONE Be sure to follow BEST PRACTICES when creating classes and interfaces

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

internal class Program
{
    private static void Main(string[] args)
    {
        //Now, create objects of your 3 classes and give their members values;
        //Creatively display and organize their values
        var car = new Car();
        car.Mpg = "Average 27 mpg";
        car.Electric = true;
        Console.WriteLine(car.Mpg);
        Console.WriteLine(car.Electric);
        Console.WriteLine($"How many miles to the gallon do these cars get?: {car.Mpg}");
        Console.WriteLine($"Is there Electric car options?: {car.Electric}");
        Console.WriteLine("");


        var truck = new Truck();
        truck.UtilityRack = true;
        truck.TruckBed = true;
        Console.WriteLine($"Does this truck have a utility rack?: {truck.UtilityRack}");
        Console.WriteLine($"Does this truck have a TruckBed {truck.TruckBed}");
        Console.WriteLine("");

        var suv = new SUV();
        suv.RoofRack = true;
        suv.CargoSpace = "87.8 cubic ft.";
        Console.WriteLine($"How much cargo space this SUV hold?: {suv.CargoSpace}");
        Console.WriteLine($"Does this truck have a RoofRack: {suv.RoofRack}");
        Console.WriteLine("");


        var vehicleList = new List<IVehicle>();
        
        vehicleList.Add(car);
        vehicleList.Add(truck);
        vehicleList.Add(suv);

       foreach (var vehicle in vehicleList)
        {
            vehicle.Drive();
            vehicle.ChangeGears(true);
            vehicle.Reverse();
        }


        
    }
}