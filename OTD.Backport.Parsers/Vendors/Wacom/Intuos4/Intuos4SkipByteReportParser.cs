using OpenTabletDriver.Plugin.Tablet;

namespace OTD.Backport.Parsers.Vendors.Wacom.Intuos4
{
    public class Intuos4SkipByteReportParser : Intuos4ReportParser
    {
        public override IDeviceReport Parse(byte[] data)
        {
            return base.Parse(data[1..^0]);
        }
    }
}