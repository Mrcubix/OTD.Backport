using OpenTabletDriver.Plugin.Tablet;

namespace OTD.Backport.Parsers.Vendors.XP_Pen
{
    public struct XP_PenAuxReport : IAuxReport
    {
        public XP_PenAuxReport(byte[] report, int index = 2)
        {
            Raw = report;

            AuxButtons = new bool[]
            {
                report[2].IsBitSet(0),
                report[2].IsBitSet(1),
                report[2].IsBitSet(2),
                report[2].IsBitSet(3),
                report[2].IsBitSet(4),
                report[2].IsBitSet(5),
                report[2].IsBitSet(6),
                report[2].IsBitSet(7)
            };
        }

        public bool[] AuxButtons { set; get; }
        public byte[] Raw { set; get; }
    }
}