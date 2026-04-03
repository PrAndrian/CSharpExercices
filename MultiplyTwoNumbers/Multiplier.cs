namespace MultiplyTwoNumbers;

/// <summary>
/// Multiply Two Numbers (Reliability - 400 pts)
///
/// Write a method that multiplies two integer numbers specified as strings.
///
/// The point of specifying numbers as strings is to allow multiplying ANY
/// integer numbers, even the ones that far exceed the usual range for built-in
/// integral numeric types (e.g. int/long).
///
/// Assumptions:
///   - strings a and b are positive integer numbers in string format
///     without any delimiters or signs (i.e. each character in the string is a digit 0-9)
///   - numbers are greater than zero
///   - numbers can be considerably larger than int.MaxValue or long.MaxValue
///
/// Test your code:
///   - "2" x "2" should return "4"
///   - "1234567891011121314151" x "1514131211109876543210" should return
///     "1869297776014035182084212977314754459421510"
///
/// Rules:
///   - You CANNOT use BigInteger class. You need to implement the multiplication logic from scratch.
///   - All the code you submit should be your own.
/// </summary>
public class Multiplier
{
    /// <summary>
    /// Multiplies two large positive integer numbers represented as strings.
    /// </summary>
    /// <param name="a">First positive integer as a string (digits only, no signs or delimiters)</param>
    /// <param name="b">Second positive integer as a string (digits only, no signs or delimiters)</param>
    /// <returns>The product of a and b, as a string</returns>
    public static string Multiply(string a, string b)
    {
        // verify that a and b are digit and has no delilmiters or signs
        if (!IsStringValid(a) || !IsStringValid(b))
            throw new ArgumentException("Input strings must be positive integers without any delimiters or signs.");

        long[] results = new long[a.Length + b.Length];

        // multiply digit by digit, accumulate all products
        for (int i = a.Length - 1; i >= 0; i--)
        {
            for (int j = b.Length - 1; j >= 0; j--)
            {
                int valueA = int.Parse(a[i].ToString());
                int valueB = int.Parse(b[j].ToString());
                results[i + j + 1] += valueA * valueB;
            }
        }

        // decalage from right to left
        for (int k = results.Length - 1; k > 0; k--)
        {
            results[k - 1] += results[k] / 10;
            results[k] = results[k] % 10;
        }

        var result = string.Join("", results).TrimStart('0');
        return result.Length == 0 ? "0" : result;
    }

    private static bool IsStringValid(string s)
    {
        foreach (var c in s)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }

        if (s.All(c => c == '0'))
        {
            return false;
        }

        return true;
    }
}
