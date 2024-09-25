public class WiFiRouter : NetworkDevice
{
    // Properties
    public int MaxSpeed { get; set; } = 0;
    public int NumAntennas { get; set; } = 0;

    // Constructor
    public WiFiRouter(string model = "Unknown", string manufacturer = "Unknown", int maxSpeed = 0, int numAntennas = 0)
        : base(model, manufacturer)
    {
        MaxSpeed = maxSpeed;
        NumAntennas = numAntennas;
    }

    // Override PrintInfo to add specific information for WiFiRouter
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"\n\tMax Speed: {MaxSpeed} Mbps\n\tNumber of Antennas: {NumAntennas}");
    }
}