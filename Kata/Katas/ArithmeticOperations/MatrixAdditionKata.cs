namespace Kata.Katas.ArithmeticOperations;

public class MatrixAdditionKata
{
    /*
     * Write a function that accepts two square matrices (N x N two dimensional arrays), and return the sum of the two.
     * Both matrices being passed into the function will be of size N x N (square), containing only integers.
       
       How to sum two matrices:
       
       Take each cell [n][m] from the first matrix, and add it with the same [n][m] cell from the second matrix. This will be cell [n][m] of the solution matrix.
     */
    
    public static int[][] MatrixAddition(int[][] a, int[][] b)
    {
        var arrayLength = a.Length;
        var result = new int[arrayLength][];
        
        for (var i = 0; i < a.Length; i++)
        {
            result[i] = new int[arrayLength];
            for (var j = 0; j < a[i].Length; j++)
            {
                result[i][j] = a[i][j] + b[i][j];
            }
        }

        return result;
    }
    
    public static int[][] MatrixAdditionAlt(int[][] a, int[][] b)
    {
        return a.Zip(b, (ax, bx) => ax.Zip(bx, (i, j) => i + j).ToArray()).ToArray();
    }
}