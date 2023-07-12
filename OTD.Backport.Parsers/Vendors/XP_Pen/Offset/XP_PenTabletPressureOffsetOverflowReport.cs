using System.Numerics;
using System.Runtime.CompilerServices;
using OpenTabletDriver.Plugin.Tablet;

namespace OTD.Backport.Parsers.Vendors.XP_Pen
{
    public struct XP_PenTabletPressureOffsetOverflowReport : ITabletReport, ITiltReport, IEraserReport
    {
        public XP_PenTabletPressureOffsetOverflowReport(byte[] report)
        {
            Raw = report;

            ReportID = report[1];
            Position = new Vector2
            {
                X = Unsafe.ReadUnaligned<ushort>(ref report[2]) | report[10] << 16,
                Y = Unsafe.ReadUnaligned<ushort>(ref report[4]) | report[11] << 16
            };
            Pressure = (uint)(Unsafe.ReadUnaligned<ushort>(ref report[6]) - 8192);
            Eraser = report[1].IsBitSet(3);

            PenButtons = new bool[]
            {
                report[1].IsBitSet(1),
                report[1].IsBitSet(2)
            };

            Tilt = new Vector2
            {
                X = (sbyte)report[8],
                Y = (sbyte)report[9]
            };
        }

        public byte[] Raw { set; get; }
        public uint ReportID { set; get; }
        public Vector2 Position { set; get; }
        public uint Pressure { set; get; }
        public bool[] PenButtons { set; get; }
        public Vector2 Tilt { set; get; }
        public bool Eraser { set; get; }
    }
}