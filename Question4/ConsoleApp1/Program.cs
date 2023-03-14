using System.Globalization;
using System.Text;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        string input = "the lord of the rings and the hobbit";
        string titleCase = ToTitleCase(input);
        Console.WriteLine(titleCase);
    }
    public static string ToTitleCase(string input)
    {
        CultureInfo culture = CultureInfo.CurrentCulture;
        TextInfo textInfo = culture.TextInfo;
        string[] words = input.Split(' ');
        StringBuilder sb = new StringBuilder();
        string[] Conjunctions;
        Conjunctions = new string[] {"the", "a", "of" };
        foreach (string word in words)
        {
            if (textInfo.ListSeparator.Contains(word))
            {
                sb.Append(word);
                sb.Append(" ");
                continue;
            }
            if (Array.IndexOf(textInfo.Conjunctions, word.ToLower()) >= 0)
            {
                sb.Append(word.ToLower());
                sb.Append(" ");
            }
            else
            {
                sb.Append(textInfo.ToTitleCase(word.ToLower()));
                sb.Append(" ");
            }
        }
        return sb.ToString().Trim();
    }
}