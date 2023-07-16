using OpenTabletDriver.Plugin.Tablet;
using OTD.Backport.Enums;
using OTD.Backport.Parsers.Tablet;

namespace OTD.Backport.Parsers.Vendors.Wacom.Intuos1
{
    public struct Intuos1ToolReport : IToolReport, IEraserReport, IProximityReport
    {
        public Intuos1ToolReport(byte[] report)
        {
            Raw = report;

            Serial = (ulong)(((report[3] & 0x0f) << 0x1C) +
                (report[4] << 0x14) + (report[5] << 0x0C) +
                (report[6] << 0x04) + (report[7] >> 0x04));

            RawToolID = (uint)((report[2] << 4) | (report[3] >> 4) |
                ((report[7] & 0x0f) << 16) | ((report[8] & 0xf0) << 8));

            Tool = report[3].IsBitSet(7) ? ToolType.Eraser : ToolType.Pen;

            Eraser = Tool == ToolType.Eraser;

            NearProximity = report[1].IsBitSet(6);
            HoverDistance = (uint)report[9] >> 2;
        }

        public byte[] Raw { set; get; }
        public ulong Serial { set; get; }
        public uint RawToolID { set; get; }
        public ToolType Tool { set; get; }
        public bool Eraser { set; get; }
        public bool NearProximity { set; get; }
        public uint HoverDistance { set; get; }
    }
}