using System;
using System.Collections.Generic;
using System.Globalization;
using System.Drawing;
class HtmlColorParser
{
    private readonly IDictionary<string, string> presetColors;

    public HtmlColorParser(IDictionary<string, string> presetColors)
    {
        this.presetColors = presetColors;
    }

    public RGB Parse(string color)
    {
        if (!color[0].Equals('#')) color = presetColors[color.ToLower()];
        color = color.Replace("#", "");
        if(color.Length == 3) color = $"{color[0]}{color[0]}{color[1]}{color[1]}{color[2]}{color[2]}";
        Color colorRBG = Color.FromArgb(Convert.ToInt32(color, 16));
    
        return new RGB(colorRBG.R, colorRBG.G, colorRBG.B);
    }
}