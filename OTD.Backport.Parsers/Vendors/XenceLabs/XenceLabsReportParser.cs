using OpenTabletDriver.Plugin.Tablet;
using OTD.Backport.Parsers.Tablet;
using OTD.Backport.Parsers.Vendors.XP_Pen;

namespace OTD.Backport.Parsers.Vendors.XenceLabs
{
    public class XenceLabsReportParser : IReportParser<IDeviceReport>
    {
        public IDeviceReport Parse(byte[] report)
        {
            var reportByte = report[1];

            if ((reportByte & 0xf0) == 0xf0)
                return new XP_PenAuxReport(report);
            else if (reportByte.IsBitSet(5))
                return new XenceLabsTabletReport(report);

            return new DeviceReport(report);
        }
    }
} 