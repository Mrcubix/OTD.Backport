using OTD.Backport.Parsers.Vendors.Wacom.Intuos4;
using OpenTabletDriver.Plugin.Tablet;
using OTD.Backport.Parsers.Tablet;

namespace OTD.Backport.Parsers.Vendors.Wacom.Intuos1
{
    public class Intuos1ReportParser : IReportParser<IDeviceReport>
    {
        public virtual IDeviceReport Parse(byte[] report)
        {
            return report[0] switch
            {
                0x02 => GetToolReport(report),
                0x10 => GetToolReport(report),
                0x03 => new Intuos1AuxReport(report),
                0x0C => new Intuos4AuxReport(report),
                _ => new DeviceReport(report)
            };
        }

        private IDeviceReport GetToolReport(byte[] report)
        {
            if (report[0] == 0x10 && report[1] == 0x20)
                return new DeviceReport(report);
            if (report[1].IsBitSet(5))
                return new Intuos1TabletReport(report);
            else if (report[1] == 0xC2)
                return new Intuos1ToolReport(report);

            return new DeviceReport(report);
        }
    }
}