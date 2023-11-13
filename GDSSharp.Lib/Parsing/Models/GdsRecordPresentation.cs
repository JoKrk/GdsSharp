﻿using GdsSharp.Lib.Models.Parsing;

namespace GdsSharp.Lib.Parsing.Models;

public class GdsRecordPresentation : IGdsRecord
{
    public int FontNumber { get; set; }
    public int VerticalPresentation { get; set; }
    public int HorizontalPresentation { get; set; }
    
    public GdsRecordPresentation(GdsBinaryReader reader, GdsHeader header)
    {
        var values = reader.ReadInt16();
        if (header.NumToRead != 2)
            throw new ArgumentException("Invalid number of bytes", nameof(header));
        
        FontNumber = values & 0b110000;
        VerticalPresentation = values & 0b1100;
        HorizontalPresentation = values & 0b11;
    }
}