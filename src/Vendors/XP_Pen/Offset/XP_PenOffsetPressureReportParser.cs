using OpenTabletDriver.Plugin.Tablet;
using OTD.Backport.Tablet;

namespace OTD.Backport.Vendors.XP_Pen.Offset
{
    public class XP_PenOffsetPressureReportParser : IReportParser<IDeviceReport>
    {
        public IDeviceReport Parse(byte[] report)
        {
            if (report[1].IsBitSet(4))
                return new XP_PenAuxReport(report);

            if (report.Length >= 12)
                return new XP_PenTabletPressureOffsetOverflowReport(report);
            if (report.Length >= 10)
                return new XP_PenPressureOffsetTiltTabletReport(report);
            else
                return new XP_PenPressureOffsetTabletReport(report);
        }
    }
}