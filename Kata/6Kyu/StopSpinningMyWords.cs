using System;

namespace Kata._6Kyu
{
    public static class StopSpinningMyWords
    {
        /*
         * Write a function that takes in a string of one or more words, and returns the same string,
         * but with all five or more letter words reversed (Just like the name of this Kata). Strings passed in will
         * consist of only letters and spaces. Spaces will be included only when more than one word is present.

            Examples: spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" spinWords( "This is a test") 
            => returns "This is a test" spinWords( "This is another test" )=> returns "This is rehtona test"
         */
        public static string SpinWords(string sentence)
        {
            var spinnedWords = new List<string>();
            
            var words = sentence.Split(' ');

            foreach (var word in words)
            {
                if (word.Length < 5)
                {
                    spinnedWords.Add(word);
                    continue;
                }

                var spinnedWord = word.Reverse();
                spinnedWords.Add(string.Join(string.Empty, spinnedWord));
            }

            var result = string.Join(" ", spinnedWords);

            return result;
        }

        public static string BetterSpinWords(string sentence)
        {
            return String.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
        }
    }
}