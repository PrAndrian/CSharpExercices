namespace MatrixRotation;

/// <summary>
/// Matrix Rotation (Problem Solving - 400 pts)
///
/// Rotate a matrix.
///
/// Input 1: (m x n) matrix of integers. m, n >= 1. m and n may be different.
/// Input 2: sequence of "C" (clockwise) and "A" (anti-clockwise) rotations to perform.
///          Each rotation is 90 (ninety) degrees. At least 1 (one) rotation is specified.
///
/// Note 1: "C" followed by "A" gets you the original matrix; so will "C" -> "C" -> "C" -> "C"
///         (i.e. four 90-degree rotations).
/// Note 2: No trigonometry is required. A "rotation" is simply moving an element from one
///         position in the 2D array to another.
///
/// Output: final rotated matrix (m x n) or (n x m) depending on the final position.
///
/// Example:
///   [1 2]  Rotated by 90 degrees clockwise gives:  [3 1]
///   [3 4]                                           [4 2]
///
/// Rules:
///   - All the code you submit should be your own.
/// </summary>
public class MatrixRotator
{
    /// <summary>
    /// Rotates a matrix according to a sequence of rotation instructions.
    /// </summary>
    /// <param name="matrix">The (m x n) matrix of integers to rotate</param>
    /// <param name="rotations">
    /// A sequence of rotation instructions where each character is either:
    ///   'C' for 90-degree clockwise rotation, or
    ///   'A' for 90-degree anti-clockwise rotation.
    /// </param>
    /// <returns>The final rotated matrix</returns>
    public static int[,] Rotate(int[,] matrix, string rotations)
    {
        foreach (var letter in rotations)
            matrix = Rotate90(matrix, letter == 'C');

        return matrix;
    }

    private static int[,] Rotate90(int[,] matrix, bool clockwise)
    {
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);
        int[,] rotated = new int[n, m];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (clockwise)
                    rotated[j, m - 1 - i] = matrix[i, j];
                else
                    rotated[n - 1 - j, i] = matrix[i, j];
            }
        }
        return rotated;
    }
}
