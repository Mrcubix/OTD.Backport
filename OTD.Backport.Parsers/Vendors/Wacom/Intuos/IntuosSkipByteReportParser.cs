using OpenTabletDriver.Plugin.Tablet;

namespace OTD.Backport.Parsers.Vendors.Wacom.Intuos
{
    public class IntuosSkipByteReportParser : IntuosReportParser
    {
        public override IDeviceReport Parse(byte[] data)
        {
            return base.Parse(data[1..^0]);
        }
    }
}