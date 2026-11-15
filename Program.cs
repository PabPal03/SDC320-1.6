/*******************************************************************
* Name: Pablo Pallas
* Date: 11/14/2026
* Assignment: SDC320 Performance Assessment - Composition
** Main application class.
*/
public class CompositionTest
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pablo Pallas - Week 1 Composition Performance Assessment");

        //Create the first automobile & add tires using Tire objects and parameters
        Automobile a1 = new Automobile("BMW", "325i", "Black", "Luxury Sedan",
            new Engine(6, "Premium Unleaded Only", true));
        a1.AddTire(new Tire("Pirelli", "205/55R16", 35, 30, "All Season Plus"));
        a1.AddTire(new Tire("Pirelli", "205/55R16", 35, 30, "All Season Plus"));
        a1.AddTire("Falken", "205/55R16", 35, 30, "All Season");
        a1.AddTire("Falken", "205/55R16", 35, 30, "All Season");
        a1.AddTire("Dorman", "135/80R17", 65, 55, "Spare");

        //Create the second automobile & add tires using Tire objects and parameters
        Automobile a2 = new Automobile("Toyota", "4-Runner", "Red", "SUV",
            new Engine(6, "Unleaded", true));
        a2.AddTire(new Tire("Bridgestone", "265/70R17", 44, 40, "All Terrain"));
        a2.AddTire(new Tire("Bridgestone", "265/70R17", 44, 40, "All Terrain"));
        a2.AddTire("Bridgestone", "265/70R17", 44, 40, "All Terrain");
        a2.AddTire("Bridgestone", "265/70R17", 44, 40, "All Terrain");
        a2.AddTire("Cooper", "265/70R17", 44, 40, "Full-Size Spare");

        //Print the first automobile using the ToString method
        Console.WriteLine();
        Console.WriteLine("Automobile 1 - Using ToString()");
        Console.WriteLine(a1);
        Console.WriteLine();

        //Print the second automobile using the GetInfo method
        Console.WriteLine();
        Console.WriteLine("Automobile 2 - Using GetBasicInfo()");
        Console.WriteLine(a2.GetInfo());
        Console.WriteLine();

        //Print the second automobile using the property accessors
        Console.WriteLine();
        Console.WriteLine("Automobile 2 - Using Properties Directly");
        Console.WriteLine("Make: {0}", a2.Make);
        Console.WriteLine("Model: {0}", a2.Model);
        Console.WriteLine("Color: {0}", a2.Color);
        Console.WriteLine("Body Style: {0}", a2.BodyStyle);
        Console.WriteLine("Cylinders: {0}", a2.EngineInfo.Cylinders);
        Console.WriteLine("Gas Type: {0}", a2.EngineInfo.GasType);
        Console.WriteLine("Fuel Injected? {0}", a2.EngineInfo.FuelInjected);
        for (int i = 0; i < a2.Tires.Count; i++)
        {
            Console.WriteLine("Tire #{0}", i + 1);
            Console.WriteLine("Manufacturer: {0}", a2.Tires[i].Manufacturer);
            Console.WriteLine("Size: {0}", a2.Tires[i].Size);
            Console.WriteLine("Min Pressure: {0}", a2.Tires[i].MinPressure);
            Console.WriteLine("Max Pressure: {0}", a2.Tires[i].MaxPressure);
            Console.WriteLine("Type: {0}", a2.Tires[i].Type);
        }
        Console.WriteLine();
    }
}