using OpenTabletDriver.Plugin.Tablet;

namespace OTD.Backport.Parsers.Vendors.Wacom.Intuos1
{
    public class Intuos1SkipByteReportParser : Intuos1ReportParser
    {
        public override IDeviceReport Parse(byte[] data)
        {
            return base.Parse(data[1..^0]);
        }
    }
}