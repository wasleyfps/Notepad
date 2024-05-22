using System;
using System.Text.RegularExpressions;

namespace Notepad
{
  public class View
  {
    public static void Show(string text)
    {
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();

      Console.WriteLine("Modo Visualização");
      Console.WriteLine("-----------");
      Replace(text);
      Console.WriteLine("-----------");
      Console.ReadKey();

      Menu.Show();
    }

    public static void Replace(string text)
    {
      var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>", RegexOptions.IgnoreCase); // Correção da expressão regular
      var matches = strong.Matches(text);

      int lastIndex = 0;
      foreach (Match match in matches)
      {
        // Print text before the match
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(text.Substring(lastIndex, match.Index - lastIndex));

        // Print the matched strong text in blue
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(match.Groups[1].Value);

        lastIndex = match.Index + match.Length;
      }

      // Print the remaining text after the last match
      Console.ForegroundColor = ConsoleColor.Black;
      if (lastIndex < text.Length)
      {
        Console.Write(text.Substring(lastIndex));
      }
    }
  }
}
