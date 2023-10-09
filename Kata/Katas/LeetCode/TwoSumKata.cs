namespace Kata.Katas.LeetCode;

public static class TwoSumKata
{
    public static int[] TwoSumBruteForce(int[] numbers, int target)
    {
        var result = new int[2];

        for (var i = 0; i < numbers.Length; i++)
        {
            if (i + 1 >= numbers.Length) return default;
            
            for (var j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] != target) continue;
                result[0] = i;
                result[1] = j;
                return result;
            }
        }

        return result;
    }

    public static int[] TwoSum(int[] numbers, int target)
    {
        var result = new int[2];
        var searchedValues = new Dictionary<int, int>();

        for (var i = 0; i < numbers.Length; i++)
        {
            var difference = target - numbers[i];
            if (searchedValues.TryGetValue(difference, out var value))
            {
                result[0] = value;
                result[1] = i;
                break;
            }
            if (searchedValues.ContainsKey(numbers[i])) continue;
            searchedValues.Add(numbers[i], i);
        }

        return result;
    }
}