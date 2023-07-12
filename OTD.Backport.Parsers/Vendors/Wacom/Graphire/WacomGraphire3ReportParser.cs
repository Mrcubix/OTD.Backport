using OpenTabletDriver.Plugin.Tablet;
using OTD.Backport.Parsers.Tablet;

namespace OTD.Backport.Parsers.Vendors.Wacom.Graphire
{
    public class WacomGraphire3ReportParser : IReportParser<IDeviceReport>
    {
        public virtual IDeviceReport Parse(byte[] report)
        {
            return report[0] switch
            {
                0x02 => GetToolReport(report),
                _ => new DeviceReport(report)
            };
        }

        private IDeviceReport GetToolReport(byte[] report)
        {
            // invalid report? need verification
            if (!report[1].IsBitSet(4))
                return new DeviceReport(report);

            // Mouse support isn't implemented yet
            if (report[1].IsBitSet(6))
                return new DeviceReport(report);
                
            return new WacomGraphire3TabletReport(report);
        }
    }
}