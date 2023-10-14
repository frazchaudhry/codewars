namespace Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            // BenchmarkRunner.Run<ValidBrace>();
            var sentence = "elephant-rides. are really fun!";
            var wordList = sentence.Split(" ");

            var result = string.Join(" ", wordList.Select(FilterWord));
            Console.WriteLine(result);
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
            if (word.Length < 4) return word;

            return $"{word.First()}{word.Length - 2}{word.Last()}";
        }
    }
}