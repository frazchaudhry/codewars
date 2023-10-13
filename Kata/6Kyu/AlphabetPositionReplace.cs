namespace Kata._6Kyu
{
    public static class AlphabetPositionReplace
    {
        public static string AlphabetPosition(string text)
        {
            //var sentence = "The sunset sets at twelve o' clock.";

            // var result = string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a'+1));
            var result = string.Join(" ", text.Where(char.IsLetter).Select(c => c & 31));

            return result;
        }
    }
}