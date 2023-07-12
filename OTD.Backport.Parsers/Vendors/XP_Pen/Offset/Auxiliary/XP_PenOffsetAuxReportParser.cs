using OpenTabletDriver.Plugin.Tablet;

namespace OTD.Backport.Parsers.Vendors.XP_Pen.Offset.Auxiliary
{
    public class XP_PenOffsetAuxReportParser : IReportParser<IDeviceReport>
    {
        public IDeviceReport Parse(byte[] report)
        {
            return new XP_PenAuxReport(report, 1);
        }
    }
}