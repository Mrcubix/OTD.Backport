using OpenTabletDriver.Plugin.Tablet;
using OTD.Backport.Parsers.Tablet;

namespace OTD.Backport.Parsers.Vendors.Veikk
{
    public class VeikkReportParser : IReportParser<IDeviceReport>
    {
        public IDeviceReport Parse(byte[] report)
        {
            if (report[2].IsBitSet(5))
                return new VeikkTabletReport(report);

            return new DeviceReport(report);
        }
    }
}