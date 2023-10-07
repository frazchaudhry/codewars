using System.Linq;

namespace Kata.Katas.StringOperations
{
    public static class AlphabetPositionReplace
    {
        public static string AlphabetPosition(string text)
        {
            //var sentence = "The sunset sets at twelve o' clock.";

            //var result = string.Join(" ", sentence.ToLower().Where(char.IsLetter).Select(x => x - 'a'+1));
            var result = string.Join(" ", text.Where(char.IsLetter).Select(c => c & 31));

            return result;
        }
    }
}