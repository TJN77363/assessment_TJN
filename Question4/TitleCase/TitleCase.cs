using System;
using System.Globalization;

class TitleCase
{
    static void Main(string[] args)
    {
        string input = "the lord of the rings";
        string[] conjunctions = { "and", "the", "a", "of", "for", "by" };

        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string[] words = input.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (Array.IndexOf(conjunctions, words[i]) == -1)
            {
                words[i] = textInfo.ToTitleCase(words[i]);
            }
        }
		int j = 0;
		words[j] = textInfo.ToTitleCase(words[j]);
        string output = string.Join(" ", words);
        Console.WriteLine(output);

    }
}