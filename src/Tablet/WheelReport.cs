using OpenTabletDriver.Plugin.Tablet;

namespace OTD.Backport.Tablet
{
    public interface IWheelReport : IDeviceReport
    {
        int Wheel { set; get; }
    }
}