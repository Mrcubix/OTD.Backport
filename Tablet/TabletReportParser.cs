using OpenTabletDriver.Plugin.Tablet;

namespace OTD.Backport.Tablet
{
    public class TabletReportParser : IReportParser<IDeviceReport>
    {
        public virtual IDeviceReport Parse(byte[] data)
        {
            return new TabletReport(data);
        }
    }
}