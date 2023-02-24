using System;
using System.Globalization;

public class TitleCase
{
    public static void Main()
    {
        string values = "the lord of the rings";

        TextInfo CapitalizeTitle = CultureInfo.CurrentCulture.TextInfo;
        Console.WriteLine("{0} --> {1}", values, CapitalizeTitle.ToTitleCase(values));
    }
} 