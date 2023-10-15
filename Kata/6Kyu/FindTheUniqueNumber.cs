namespace Kata._6Kyu;

public class FindTheUniqueNumber
{
    /*
     * There is an array with some numbers. All numbers are equal except for one. Try to find it!
     * Kata.FindUniq(new[] { 1, 1, 1, 2, 1, 1 }); // => 2
     * Kata.FindUniq(new[] { 0, 0, 0.55, 0, 0 }); // => 0.55
     * It’s guaranteed that array contains at least 3 numbers.
     * The tests contain some very huge arrays, so think about performance.
     */
    public static int GetUnique(IEnumerable<int> numbers)
    {
        var result = 0;
        var slice = numbers.ToArray()[0..3];
    
        var a = slice[0];
        var b = slice[1];
        var c = slice[2];
    
        if (a != b && a != c) return result = a;
    
        foreach (var number in numbers)
        {
            if (number != a)
            {
                result = number;
                break;
            }
        }
    
        return result;
    }
}