/*******************************************************************
* Name: Pablo Pallas
* Date: 11/14/2026
* Assignment: SDC320 Performance Assessment - Composition
** This class represents an Engine object, which is one of the
* component parts of an Automobile. This class includes Cylinders,
* GasType, and FuelInjected properties. The constructor takes
* parameters to set all properties.
*/
public class Engine
{
    //Class properties
    public int Cylinders { get; set; }
    public string GasType { get; set; }
    public bool FuelInjected { get; set; }

    public Engine(int cylinders, string gasType, bool fuelInjected)
    {
        Cylinders = cylinders;
        GasType = gasType;
        FuelInjected = fuelInjected;
    }
}