using OpenTabletDriver.Plugin.Tablet;
using OTD.Backport.Parsers.Tablet;
using OTD.Backport.Parsers.Vendors.Wacom.Intuos;

namespace OTD.Backport.Parsers.Vendors.Wacom.Intuos4
{
    public class Intuos4ReportParser : IReportParser<IDeviceReport>
    {
        public virtual IDeviceReport Parse(byte[] report)
        {
            return report[0] switch
            {
                0x02 => GetToolReport(report),
                0x0C => new Intuos4AuxReport(report),
                _ => new DeviceReport(report)
            };
        }

        private IDeviceReport GetToolReport(byte[] report)
        {
            if (report[0] == 0x10 && report[1] == 0x20)
                return new DeviceReport(report);
            // Pen in range
            if (report[1].IsBitSet(5))
                return new IntuosTabletReport(report);
            
            return new DeviceReport(report);
        }
    }
}