using System.Text.RegularExpressions;
/*
string[] partNumbers = { "1298-673-4192", "A08Z-931-468a", "_A90-123-129X", "12345-KKA-1230", "0919-2893-1256" };
string pattern = @"^[A-Z0-9]\d{2}[A-Z0-9](-\d{3}){2}[A-Z0-9]$";
foreach (string partNumber in partNumbers)
{
    if (Regex.IsMatch(partNumber, pattern, RegexOptions.IgnoreCase))
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}
*/
/*
string pattern = @"\ba\w*\b";
string input = "The extraordinary day dawns with any new day.";
Match m = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
if (m.Success)
    Console.WriteLine("Found '{0}' at position {1}.", m.Value, m.Index);
else
    Console.WriteLine("---"); // <--
*/
/*
string pattern = @"\b\w+es\b"; // slovo obsahující písmena "es" - [mezera][slovo]es[mezera]
string sentence = "NOTES: Any notes or comments are optional.";
foreach (Match match in Regex.Matches(sentence, pattern, RegexOptions.None, TimeSpan.FromSeconds(1)))
{
    Console.WriteLine("Found '{0}' at position {1}", match.Value, match.Index); // notes
}
*/
