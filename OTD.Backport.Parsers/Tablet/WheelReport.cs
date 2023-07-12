using OpenTabletDriver.Plugin.Tablet;

namespace OTD.Backport.Parsers.Tablet
{
    public interface IWheelReport : IDeviceReport
    {
        int Wheel { set; get; }
    }
}