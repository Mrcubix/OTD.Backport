using OpenTabletDriver.Plugin.Tablet;

namespace OTD.Backport.Tablet
{
    public class DeviceReportParser : IReportParser<IDeviceReport>
    {
        public virtual IDeviceReport Parse(byte[] data)
        {
            return new DeviceReport(data);
        }
    }
}