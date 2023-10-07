namespace Kata.Katas.StringOperations;

public class BreakCamelCase
{
    // Write a function that will break up camel casing, using a space between words
    // e.g camelCasing becomes "camel Casing"
    public static string Break(string str)
    {
        List<int> capitalIndices = new();
        for (var i = 0; i < str.Length; i++)
        {
            if (char.IsUpper(str[i])) capitalIndices.Add(i);
        }

        List<string> words = new();
        var x = 0;
        foreach (var index in capitalIndices)
        {
            words.Add(str[x..index]);
            x = index;
        }
        words.Add(str[x..]);

        return string.Join(" ", words);
    }

    public static string BreakBetter(string str)
    {
        return string.Concat(str.Select(c => char.IsUpper(c) ? " " + c : c.ToString()));
    }
}