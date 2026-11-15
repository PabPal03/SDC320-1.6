/*******************************************************************
* Name: Pablo Pallas
* Date: 11/14/2026
* Assignment: SDC320 Performance Assessment - Composition
** This class represents an Automobile object, which is composed of an
* Engine object and a collection of Tire objects. This class includes
* Make, Model, Color, BodyStyle, EngineInfo, and Tires properties.
* GetInfo returns the basic automobile information, ToString returns
* all automobile information, and AddTire adds a tire to the Tires
* collection, either as a Tire object or from parameters.
*/
public class Automobile
{
    //Class properties
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public string BodyStyle { get; set; }
    public Engine EngineInfo { get; set; }
    public List<Tire> Tires { get; set; }

    public Automobile(string make, string model, string color,
        string bodyStyle, Engine engineInfo)
    {
        Make = make;
        Model = model;
        Color = color;
        BodyStyle = bodyStyle;
        EngineInfo = engineInfo;
        Tires = new List<Tire>();
    }

    //Add a tire object to the Tires collection
    public void AddTire(Tire tire)
    {
        Tires.Add(tire);
    }

    //Create a tire object from the parameters and add it to the collection
    public void AddTire(string manufacturer, string size, int maxPressure,
        int minPressure, string type)
    {
        Tires.Add(new Tire(manufacturer, size, maxPressure, minPressure, type));
    }

    public string GetInfo()
    {
        return string.Format(
            "Make: {0}\nModel: {1}\nColor: {2}\nEngine:\n\tCylinder Count: {3}\n"
                + "\tFuel Injected? {4}\nNumber of Tires: {5}",
            Make, Model, Color, EngineInfo.Cylinders, EngineInfo.FuelInjected,
            Tires.Count);
    }

    public override string ToString()
    {
        string info = string.Format(
            "Make: {0}\nModel: {1}\nColor: {2}\nBody Style: {3}\n"
                + "Engine Cylinders: {4}\nGas Type: {5}\nFuel Injected? {6}",
            Make, Model, Color, BodyStyle, EngineInfo.Cylinders,
            EngineInfo.GasType, EngineInfo.FuelInjected);

        for (int i = 0; i < Tires.Count; i++)
        {
            info += string.Format(
                "\nTire {0}\n\tMfg: {1}\n\tSize: {2}\n\tMax Pressure: {3}\n"
                    + "\tMin Pressure: {4}\n\tType: {5}\n",
                i + 1, Tires[i].Manufacturer, Tires[i].Size,
                Tires[i].MaxPressure, Tires[i].MinPressure, Tires[i].Type);
        }

        return info;
    }
}