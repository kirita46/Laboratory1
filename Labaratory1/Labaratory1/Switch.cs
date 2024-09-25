public class Switch : NetworkDevice
{
    // Properties
    public int NumPorts { get; set; } = 0;
    public bool IsManaged { get; set; } = false;

    // Constructor
    public Switch(string model = "Unknown", string manufacturer = "Unknown", int numPorts = 0, bool isManaged = false)
        : base(model, manufacturer)
    {
        NumPorts = numPorts;
        IsManaged = isManaged;
    }

    // Override PrintInfo to add specific information for Switch
    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"\n\tNumber of Ports: {NumPorts}\n\tManaged: {(IsManaged ? "Yes" : "No")}");
    }
}