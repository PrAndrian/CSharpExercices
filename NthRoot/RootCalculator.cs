namespace NthRoot;

/// <summary>
/// Nth Root (400 pts)
///
/// Write a method that returns the nth root of a given positive number.
///
/// Input:
///   - number: double (>= 1.00)
///   - root:   int    (>= 1)
///
/// Output:
///   The nth root of number.
///
/// Rules:
///   - You can only use the 4 basic math operations: + - * /
///   - You CANNOT use any Math.* methods.
///   - All the code you submit should be your own.
/// </summary>
public class RootCalculator
{
    /// <summary>
    /// Computes the nth root of the given number using only +, -, *, / operators.
    /// </summary>
    /// <param name="number">The number to compute the root of (>= 1.00)</param>
    /// <param name="root">The degree of the root (>= 1)</param>
    /// <returns>The nth root of the number</returns>
    public static double NthRoot(double number, int root)
    {
        /** "NthRoot": Quel nombre multiplié par lui-même 'root' fois donne 'number' ?
        * Exemple : Quel nombre multiplier par lui même 3 fois donne 27 ?
        * 3 x 3 x 3 = 27 donc rep = 3
        * Sachant que
        * X^3 = 27
        * X = 27^(1/3)
        * Faisons une methode Power(number,1/root) alors.
        * Problème c'est que 1/3 = ~0.33
        * Et on ne peut pas boucler 0.33 fois
        * La valeur 1 < X < number (racine ne peut pas être + grand que number)
        * On va donc faire une recherche sur la meilleurs valeurs pour X possible
        **/

        /** ALGO
        * minValue = 1
        * maxValue = number
        * TANT QUE maxValue - minValue > 0.0000001 (valeur la plus proche)
        * candidat = (minValue + maxValue) / 2
        * FAIRE res = Power de candidat à la puissance root
        * SI res > number
        * ALORS maxValue = candidat
        * SI res < number
        * ALORS minValue = candidat
        **/

        var minValue = 1.00;
        var maxValue = number;
        var precision = 0.0000001;
        while (maxValue - minValue > precision)
        {
            var candidate = (minValue + maxValue) / 2;
            var res = Power(candidate, root);
            if (res > number)
            {
                maxValue = candidate;
            }
            else
            {
                minValue = candidate;
            }
        }
        return (minValue + maxValue) / 2;
    }

    public static double Power(double baseValue, int exponential)
    {
        var res = 1.00;
        if (exponential == 0) return 1;

        for (int i = 0; i < exponential; i++)
        {
            res *= baseValue;
        }

        return res;
    }
}
