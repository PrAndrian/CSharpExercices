namespace SameHashCode;

/// <summary>
/// Same Hash Code (400 pts)
///
/// Write a method that will produce three (3) different strings A, B, C such that:
///
///   A != B != C
///
///   Hash(A) == Hash(B) == Hash(C)
///
/// The hash function should be the default function provided by the language.
/// In C#, this is string.GetHashCode().
///
/// Rules:
///   - All the code you submit should be your own.
/// </summary>
public class HashCollisionFinder
{
    /// <summary>
    /// Finds three different strings that all produce the same hash code
    /// using string.GetHashCode().
    /// </summary>
    /// <returns>
    /// A tuple of three distinct strings (A, B, C) where:
    ///   A != B, B != C, A != C
    ///   and A.GetHashCode() == B.GetHashCode() == C.GetHashCode()
    /// </returns>
    public static (string A, string B, string C) FindThreeCollisions()
    {
        /** HashCode donne valeur qu'on ne peut pas prédire
         * Tester sur les hashcodes diffférents et les strings différentes qui donnent le même hashcode
         * On doit stocker les strings et les hashcodes
         * Le premier qui a 3 hashcodes identiques => on retournes les 3 strings
         */

        /** ALGO
         * dico = Dictionaire<hashcode, string[]>
         * TANT QUE taille != 3 pour la liste des strings un des hashcode alors
         * hcX1 = hashcode de par string X{n} où n à l'infini
         * si hcX1 exist dejà dans dico
         * alors ajouter string X1 pour clef hcX1
         * sinon ajouter hcX1 => string[X1] dans dico
         * stocker dans le dictionnaire hashcode de X1 => string[X1]
         * alors on ajoute X2 dans la liste des strings pour ce hashcode
         * i++
         *
         * Retourne les 3 strings
         **/


        var hashToStrings = new Dictionary<int, List<string>>();
        int i = 0;
        while (true)
        {
            var candidate = "X" + i;
            var hashCode = candidate.GetHashCode();
            if (hashToStrings.TryGetValue(hashCode, out var strings))
            {
                if (!strings.Contains(candidate))
                {
                    strings.Add(candidate);
                    if (strings.Count == 3)
                    {
                        return (strings[0], strings[1], strings[2]);
                    }
                }
            }
            else
            {
                hashToStrings[hashCode] = new List<string> { candidate };
            }
            i++;
        }
    }
}
