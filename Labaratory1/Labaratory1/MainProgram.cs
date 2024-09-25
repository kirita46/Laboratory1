using System;
using System.Collections.Generic;

class Program
{
    static void CreateAndAddDevice(List<NetworkDevice> devices)
    {
        Console.WriteLine("Choose device to create:\n1. NetworkDevice\n2. WiFiRouter\n3. Switch\nChoice: ");
        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter model: ");
        string model = Console.ReadLine();
        Console.WriteLine("Enter manufacturer: ");
        string manufacturer = Console.ReadLine();

        if (choice == 1)
        {
            devices.Add(new NetworkDevice(model, manufacturer));
        }
        else if (choice == 2)
        {
            Console.WriteLine("Enter max speed: ");
            int maxSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of antennas: ");
            int numAntennas = int.Parse(Console.ReadLine());
            devices.Add(new WiFiRouter(model, manufacturer, maxSpeed, numAntennas));
        }
        else if (choice == 3)
        {
            Console.WriteLine("Enter number of ports: ");
            int numPorts = int.Parse(Console.ReadLine());
            Console.WriteLine("Is managed (1 for yes, 0 for no): ");
            bool isManaged = int.Parse(Console.ReadLine()) == 1;
            devices.Add(new Switch(model, manufacturer, numPorts, isManaged));
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }
    }

    static void PrintDevices(List<NetworkDevice> devices)
    {
        foreach (var device in devices)
        {
            Console.WriteLine("Device details:");
            device.PrintInfo();
        }
    }

    static void Main(string[] args)
    {
        List<NetworkDevice> devices = new List<NetworkDevice>();
        int choice;

        while (true)
        {
            Console.WriteLine("1. Add a device\n2. Print devices\n3. Exit\nChoice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                CreateAndAddDevice(devices);
            }
            else if (choice == 2)
            {
                PrintDevices(devices);
            }
            else if (choice == 3)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice!");
            }
        }
    }
}
