using OpenTabletDriver.Plugin.Tablet;

namespace OTD.Backport.Parsers.Tablet
{
    public struct DeviceReport : IDeviceReport
    {
        internal DeviceReport(byte[] report)
        {
            Raw = report;
        }

        public byte[] Raw { set; get; }
    }
}