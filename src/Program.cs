using System.Text.RegularExpressions;

namespace ExpReg;

partial class Program
{
    [GeneratedRegex(@"#\w+")]
    
     private static partial Regex HashtagRegex();
    static void Main(string[] args)
    {
        var bic = "ATCICIAB";

        Console.Write($"Le BIC '{bic}' est ");
        if (Regex.IsMatch(bic, "[A-Z]{6}[A-Z0-9]{2,5}"))
        {
            Console.WriteLine("valide.");
        }
        else
        {
            Console.WriteLine("non valide.");
        }

        var twitGeorgeSand = "Tu fuyais la #solitude et la trouvait #partout.";

        var hashtags = HashtagRegex().Matches(twitGeorgeSand); // TODO : Extraire #\w+

        foreach (var tag in hashtags)
        {
            Console.WriteLine(tag);
        }

        var html = twitGeorgeSand;

        Console.WriteLine(html);
    }
}
