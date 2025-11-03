using System.Text;

public static class Identifier
{
    private static bool IsGreekLowercase(char c) => (c >= 'α' && c <= 'ω');
    public static string Clean(string identifier)
    {
        var stringBuilder = new StringBuilder();
        var isCamelCase = false;
        foreach (var c in identifier)
        {
            stringBuilder.Append(c switch
            {
                _ when IsGreekLowercase(c) => null,
                _ when isCamelCase => char.ToUpperInvariant(c),
                _ when char.IsWhiteSpace(c) => '_',
                _ when char.IsControl(c) => "CTRL",
                _ when char.IsLetter(c) => c,
                _ => null,
            });
            isCamelCase = c.Equals('-');
        }
        return stringBuilder.ToString();
    }
}
