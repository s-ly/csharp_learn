namespace App;

public class Controller {
  public static void Loop() {
    bool exit = false;
    while (!exit) {
      ConsoleKeyInfo key = Console.ReadKey(true);
      switch (key.Key) {
        case ConsoleKey.Escape:
          exit = true;
          break;
        case ConsoleKey.Enter:
          Console.WriteLine("Enter");
          break;
          // case ConsoleKey.UpArrow:
          //   Console.SetCursorPosition(left: 0, top: 0);
          //   Console.WriteLine("Стрелка вверх нажата!");
          //   break;
          // case ConsoleKey.DownArrow:
          //   Console.SetCursorPosition(left: 0, top: 0);
          //   Console.WriteLine("Стрелка вниз нажата!");
          //   break;
      }
    }

  }
}
