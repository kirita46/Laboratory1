using System;

public class NetworkDevice
{
    // Properties to replace private fields and getters/setters
    public string Model { get; set; } = "Unknown";
    public string Manufacturer { get; set; } = "Unknown";

    // Constructor with default values
    public NetworkDevice(string model = "Unknown", string manufacturer = "Unknown")
    {
        Model = model;
        Manufacturer = manufacturer;
    }

    // Virtual method to display device information
    public virtual void PrintInfo()
    {
        Console.WriteLine($"\tModel: {Model}\n\tManufacturer: {Manufacturer}");
    }
}