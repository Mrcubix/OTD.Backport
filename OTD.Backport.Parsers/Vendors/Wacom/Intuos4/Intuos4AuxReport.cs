using OpenTabletDriver.Plugin;
using OpenTabletDriver.Plugin.Tablet;
using OTD.Backport.Parsers.Tablet;

namespace OTD.Backport.Parsers.Vendors.Wacom.Intuos4
{
    public struct Intuos4AuxReport : IAuxReport, IWheelReport
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

            // Wheel value is between 0x80 and 0xC7, check if value is above or equal to 0x80 using bitwise operator and subtract 0x80 if true
            Wheel = report[1] > 0x79 ? report[1] - 0x80 : -1;
        }

        public bool[] AuxButtons { set; get; }
        public int Wheel { set; get; }
        public byte[] Raw { set; get; }
    }
}