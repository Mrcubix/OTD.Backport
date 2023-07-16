using OpenTabletDriver.Plugin.Tablet;
using OTD.Backport.Enums;

namespace OTD.Backport.Parsers.Tablet
{
    /// <summary>
    /// A device report containing information about the current tool.
    /// </summary>
    public interface IToolReport : IDeviceReport
    {
        /// <summary>
        /// A serial number for the currently active tool.
        /// </summary>
        ulong Serial { set; get; }

        /// <summary>
        /// The currently active tool identifier, typically used like a model number.
        /// </summary>
        uint RawToolID { set; get; }

        /// <summary>
        /// The currently active tool type.
        /// </summary>
        ToolType Tool { set; get; }
    }
}