using GdsSharp.Lib.Abstractions;

namespace GdsSharp.Lib.Models.Elements;

public class GdsNodeElement : IGdsLayeredElement
{
    public short NodeType { get; set; }
    public IList<GdsPoint> Points { get; set; } = new List<GdsPoint>();
    public bool ExternalData { get; set; }
    public bool TemplateData { get; set; }
    public short PlexNumber { get; set; }
    public short Layer { get; set; }
}