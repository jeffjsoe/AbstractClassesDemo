//JESUS
using ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* Todo follow all comments!! 
*/

#region Vehicles

/*
 * Create an abstract class called Vehicle
 * The vehicle class shall have three string properties Year, Make, and Model
 * Set the defaults to something generic in the Vehicle class
 * Vehicle shall have an abstract method called DriveAbstract with no implementation
 * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
 */



/* 
 * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
 * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
 * Provide the implementations for the abstract methods
 * Only in the Motorcycle class will you override the virtual drive method
*/

// Create a list of Vehicle called vehicles

var vehicles = new List<Vehicle>();

//List<Vehicle> vehicles = new List<Vehicle>();

/*
 * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
 * - new it up as one of each derived class
 * Set the properties with object initializer syntax
 */

var car1 = new Car() { HasTrunk = false, Make = "Lotus", Model = "Ford", Year = "2002" };
var motor1 = new Motercycle() { HasSideCart = true, Year = "2001", Make = "Yamaha", Model = "Ninja" };
//We cannot create a new instance of Vehicle since it is an abtract class
Vehicle vehicle1 = new Car() { HasTrunk = true, Make = "Honda", Model = "Odyssey", Year = "2003" };
Vehicle vehicle2 = new Motercycle() { HasSideCart = false, Make = "Honda", Year = "2004" };
/*
 * Add the 4 vehicles to the list

 * Using a foreach loop iterate over each of the properties
 */

vehicles.Add(car1);
vehicles.Add(motor1);
vehicles.Add(vehicle2);
vehicles.Add(vehicle1);




foreach (var vehicle in vehicles)
{
    Console.WriteLine($"year {vehicle.Year}, {vehicle.Make}, {vehicle.Model}");

}

// Call each of the drive methods for one car and one motorcycle
car1.DriveVirtual();
motor1.DriveVirtual();
car1.DriveAbstract();
motor1.DriveAbstract();
#endregion
Console.ReadLine();
