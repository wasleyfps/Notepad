using System;

namespace Notepad
{
  public static class Menu
  {
    public static void Show()
    {
      Console.Clear();
      DrawScreen();
      WriteOptions();
    }

    public static void DrawScreen()

    {
      BorderProgram();

      Lines();

      BorderProgram();

      WriteOptions();

      var option = short.Parse(Console.ReadLine());
      HandleMenuOption(option);
    }

    public static void Lines()
    {
      for (int lines = 0; lines <= 10; lines++)
      {
        Console.Write("|");
        for (int i = 0; i <= 30; i++)
          Console.Write(" ");

        Console.Write("|");
        Console.Write("\n");
      }
    }

    public static void BorderProgram()
    {
      Console.Write("+");
      for (int i = 0; i <= 30; i++)
        Console.Write("-");

      Console.Write("+");
      Console.Write("\n");
    }

    public static void WriteOptions()
    {
      Console.SetCursorPosition(3, 2);
      Console.WriteLine("Editor de Texto");
      Console.SetCursorPosition(3, 3);
      Console.WriteLine("===============");
      Console.SetCursorPosition(3, 4);
      Console.WriteLine("Selecione uma Opção abaixo: ");
      Console.SetCursorPosition(3, 6);
      Console.WriteLine("1 - Novo Arquivo");
      Console.SetCursorPosition(3, 7);
      Console.WriteLine("2 - Abrir");
      Console.SetCursorPosition(3, 9);
      Console.WriteLine("0 - Sair");

      Console.SetCursorPosition(3, 10);
      Console.Write("Opção: ");
    }

    public static void HandleMenuOption(short option)
    {
      switch (option)
      {
        case 1: Editor.Show(); break;
        case 2: Console.WriteLine("View"); break;
        case 3:
          {
            Console.Clear();
            Environment.Exit(0);
            break;

          };
        default: Show(); break;
      }
    }

  }
}
