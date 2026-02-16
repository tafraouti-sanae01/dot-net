using System.Data;
using System.Diagnostics;

namespace Tableaux;

class Program
{
    static void Afficher(string[] liste)
    {
        foreach (var c in liste)
        {
            Console.WriteLine(c);
        }
    }

    static void Main(string[] args)
    {
        var couleurs = "rouge,orange,jaune,vert,bleu,violet".Split(",");

        Afficher(couleurs);
        Console.WriteLine();

        #region Boucle d'initialisation
        var couleursMaj = new string[couleurs.Length];

        for (int i = 0; i < couleurs.Length; i++)
        {
            couleursMaj[i] = couleurs[i].ToUpper();
        }
        #endregion
        Afficher(couleursMaj);
        Console.WriteLine();

        couleurs[^1] = "Violet";
        Afficher(couleurs[0..3]);
        Console.WriteLine("---");
        Afficher(couleurs[^2..]);
    }
}
