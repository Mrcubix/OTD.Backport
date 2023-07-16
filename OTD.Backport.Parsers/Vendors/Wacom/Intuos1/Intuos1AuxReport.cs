using OpenTabletDriver.Plugin.Tablet;
using OTD.Backport.Parsers.Tablet;

namespace OTD.Backport.Parsers.Vendors.Wacom.Intuos1
{
    public struct Intuos1AuxReport : IAuxReport, IWheelReport
    {
        public Intuos1AuxReport(byte[] report)
        {
            Raw = report;

            var auxByte = report[4];
            AuxButtons = new bool[]
            {
                auxByte.IsBitSet(0),
                auxByte.IsBitSet(1),
                auxByte.IsBitSet(2),
                auxByte.IsBitSet(3),
                auxByte.IsBitSet(4),
                auxByte.IsBitSet(5),
                auxByte.IsBitSet(6),
                auxByte.IsBitSet(7),
            };

            Wheel = report[2] > 0x79 ? report[2] - 0x80 : -1;
        }

        public byte[] Raw { set; get; }
        public bool[] AuxButtons { set; get; }
        public int Wheel { get; set; }
    }
}