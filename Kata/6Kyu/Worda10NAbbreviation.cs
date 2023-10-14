using System.Text.RegularExpressions;

namespace Kata._6Kyu;

public class Worda10NAbbreviation
{
    /*
     * The word i18n is a common abbreviation of internationalization in the developer community, used instead of typing the whole word and trying to spell it correctly. Similarly, a11y is an abbreviation of accessibility.

       Write a function that takes a string and turns any and all "words" (see below) within that string of length 4 or greater into an abbreviation, following these rules:

       A "word" is a sequence of alphabetical characters. By this definition, any other character like a space or hyphen (eg. "elephant-ride") will split up a series of letters into two words (eg. "elephant" and "ride").
       The abbreviated version of the word should have the first letter, then the number of removed characters, then the last letter (eg. "elephant ride" => "e6t r2e").

       Examples:
       abbreviate("elephant-rides are really fun!")
       //          ^^^^^^^^*^^^^^*^^^*^^^^^^*^^^*
       // words (^):   "elephant" "rides" "are" "really" "fun"
       //                123456     123     1     1234     1
       // ignore short words:               X              X

       // abbreviate:    "e6t"     "r3s"  "are"  "r4y"   "fun"
       // all non-word characters (*) remain in place
       //                     "-"      " "    " "     " "     "!"
       === "e6t-r3s are r4y fun!"
     */
    public static string Abbreviate(string input)
    {
        var wordList = input.Split(" ");

        return string.Join(" ", wordList.Select(FilterWord));
    }

    private static string FilterWord(string word)
    {
        var nonLetters = new Queue<char>();
        foreach (var t in word.Where(t => !char.IsLetter(t)))
        {
            nonLetters.Enqueue(t);
        }

        if (nonLetters.Count < 1) return AbbreviateWord(word);
        var charToRemove = nonLetters.Dequeue();
        if (!word.Contains(charToRemove)) return AbbreviateWord(word);
        var wordSplit = word.Split(charToRemove);

        return string.Join(charToRemove, wordSplit.Select(FilterWord));
    }

    private static string AbbreviateWord(string word)
    {
        return word.Length < 4 ? word : $"{word.First()}{word.Length - 2}{word.Last()}";
    }
    
    public static string AbbreviateAlt(string input)
    {
        return Regex.Replace(input, @"\w{4,}", m => string.Concat(m.ToString().First(), m.ToString().Length - 2, m.ToString().Last()));
    }
    
    public static string AbbreviateAlt2(string input)
    {
        return Regex.Replace(input, @"\B\w{2,}\B", m => m.Length.ToString());
    }
}