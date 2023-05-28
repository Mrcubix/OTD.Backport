using OpenTabletDriver.Plugin.Tablet;

namespace OTD.Backport.Vendors.Wacom.Intuos4
{
    public struct Intuos4AuxReport : IAuxReport
    {
        public Intuos4AuxReport(byte[] report)
        {
            Raw = report;

            AuxButtons = new bool[]
            {
                report[3].IsBitSet(0),
                report[3].IsBitSet(1),
                report[3].IsBitSet(2),
                report[3].IsBitSet(3),
                report[3].IsBitSet(4),
                report[3].IsBitSet(5),
                report[3].IsBitSet(6),
                report[3].IsBitSet(7),
            };

            AuxWheel = report[1];
        }

        public bool[] AuxButtons { set; get; }
        public int AuxWheel { set; get; }
        public byte[] Raw { set; get; }
    }
}