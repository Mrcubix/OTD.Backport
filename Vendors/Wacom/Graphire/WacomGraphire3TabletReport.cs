using System.Numerics;
using System.Runtime.CompilerServices;
using OpenTabletDriver.Plugin.Tablet;

namespace OTD.Backport.Vendors.Wacom.Graphire
{
    public struct WacomGraphire3TabletReport : ITabletReport, IEraserReport
    {
        public WacomGraphire3TabletReport(byte[] report)
        {
            Raw = report;

            ReportID = 0;
            Position = new Vector2
            {
                X = Unsafe.ReadUnaligned<ushort>(ref report[2]),
                Y = Unsafe.ReadUnaligned<ushort>(ref report[4])
            };
            Pressure = Unsafe.ReadUnaligned<ushort>(ref report[6]);

            PenButtons = new bool[]
            {
                report[1].IsBitSet(1),
                report[1].IsBitSet(2)
            };
            Eraser = report[1].IsBitSet(5);
        }

        public byte[] Raw { set; get; }
        public uint ReportID {get; set;}
        public Vector2 Position { set; get; }
        public uint Pressure { set; get; }
        public bool[] PenButtons { set; get; }
        public bool Eraser { set; get; }
    }
} 