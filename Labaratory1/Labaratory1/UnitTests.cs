using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class NetworkDeviceTests
{
    [TestMethod]
    public void TestNetworkDeviceCreation()
    {
        var device = new NetworkDevice("ModelX", "ManufacturerY");
        Assert.AreEqual("ModelX", device.Model);
        Assert.AreEqual("ManufacturerY", device.Manufacturer);
    }

    [TestMethod]
    public void TestWiFiRouterCreation()
    {
        var router = new WiFiRouter("RouterModel", "RouterManufacturer", 100, 4);
        Assert.AreEqual(100, router.MaxSpeed);
        Assert.AreEqual(4, router.NumAntennas);
    }

    [TestMethod]
    public void TestSwitchCreation()
    {
        var sw = new Switch("SwitchModel", "SwitchManufacturer", 24, true);
        Assert.AreEqual(24, sw.NumPorts);
        Assert.IsTrue(sw.IsManaged);
    }
}