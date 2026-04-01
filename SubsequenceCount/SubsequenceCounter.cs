namespace SubsequenceCount;

/// <summary>
/// Subsequence Count (400 pts)
///
/// Ayant une chaîne x, trouver toutes les occurrences de x en tant que
/// sous-séquence dans y (comparaison insensible à la casse).
///
/// Une sous-séquence est une séquence de caractères qui apparaît dans le
/// même ordre dans y, mais pas nécessairement de manière consécutive.
///
/// Input:
///   - x: string (la sous-séquence à chercher)
///   - y: string (la chaîne dans laquelle chercher)
///
/// Output:
///   Le nombre de sous-séquences distinctes de y qui sont égales à x.
///
/// Exemples:
///   x = "hsr", y = "HSFLDSRHPASR" => 6
///   x = "AA",  y = "AAA"          => 3
///
/// Rules:
///   - La comparaison est insensible à la casse.
///   - All the code you submit should be your own.
/// </summary>
public class SubsequenceCounter
{
    /// <summary>
    /// Counts the number of distinct subsequences of y that are equal to x
    /// (case-insensitive comparison).
    /// </summary>
    /// <param name="x">The subsequence pattern to search for</param>
    /// <param name="y">The string to search in</param>
    /// <returns>The number of distinct subsequences of y matching x</returns>
    public static long CountOccurrences(string x, string y)
    {
        // TODO: Implement logic
        throw new NotImplementedException();
    }
}
