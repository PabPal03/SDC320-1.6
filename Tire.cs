/*******************************************************************
* Name: Pablo Pallas
* Date: 11/14/2026
* Assignment: SDC320 Performance Assessment - Composition
** This class represents a Tire object, which is one of the component
* parts of an Automobile. This class includes Manufacturer, Size,
* MaxPressure, MinPressure, and Type properties. The constructor takes
* parameters to set all properties.
*/
public class Tire
{
    //Class properties
    public string Manufacturer { get; set; }
    public string Size { get; set; }
    public int MaxPressure { get; set; }
    public int MinPressure { get; set; }
    public string Type { get; set; }

    public Tire(string manufacturer, string size, int maxPressure,
        int minPressure, string type)
    {
        Manufacturer = manufacturer;
        Size = size;
        MaxPressure = maxPressure;
        MinPressure = minPressure;
        Type = type;
    }
}