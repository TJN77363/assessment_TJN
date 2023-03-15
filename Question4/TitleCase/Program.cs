using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string input = "the lord of the ring";
        string[] conjunctions = { "and", "the", "a", "of", "for" };

        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (Array.IndexOf(conjunctions, words[i]) == -1)
            {
                words[i] = textInfo.ToTitleCase(words[i]);
            }
        }
        string output = string.Join(" ", words);
        Console.WriteLine(output);
    }
}
