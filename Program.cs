using App;

namespace HelloWorld;

class Program {
  static void Main(string[] args) {
    // Printer.PrintTest();
    // Printer.PrintBoard();
    // Printer printer = new Printer();
    // printer.PrintAll();


    Screen screen = new Screen(30);

    // Pixel pixel = new Pixel();
    // pixel.SetPixelSymbol(Symbol.blockVeryLow, Symbol.blockVeryLow);
    // screen.Fill(pixel);

    // screen.MakePoint();
    // screen.MakePoint(5, 5);
    // screen.MakePoint(10, 10);
    screen.MakeLine(x1: 9, y1: 1, x2: 1, y2: 5);
    screen.MakeLine(x1: 30, y1: 30, x2: 1, y2: 5);
    screen.Draw();
  }





















  static void Draw() {
    Console.Clear();
    Console.CursorVisible = false;
    Console.WriteLine("Hello, World!");
    Console.SetCursorPosition(left: 20, top: 5);
    Console.Write("111");
    Console.Write("222");
    Console.WriteLine("Hello, World!");
    Console.SetCursorPosition(left: 1, top: 1);
    Console.Write("333");
    Console.SetCursorPosition(left: 0, top: 10);
  }

  static void LoopGame() {
    bool exit = false;
    while (!exit) {
      ConsoleKeyInfo key = Console.ReadKey(true);
      switch (key.Key) {
        case ConsoleKey.Escape:
          exit = true;
          break;
        case ConsoleKey.Enter:
          Console.Beep(); // Звуковой сигнал
          break;
        case ConsoleKey.UpArrow:
          Console.SetCursorPosition(left: 0, top: 0);
          Console.WriteLine("Стрелка вверх нажата!");
          break;
        case ConsoleKey.DownArrow:
          Console.SetCursorPosition(left: 0, top: 0);
          Console.WriteLine("Стрелка вниз нажата!");
          break;
      }
    }
  }
  static void ShowMenu(string[] items, int selectedIndex) {
    Console.Clear();
    for (int i = 0; i < items.Length; i++) {
      if (i == selectedIndex) {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.White;
      }
      Console.WriteLine($"  {items[i]}  ");
      Console.ResetColor();
    }
  }

  static void Loop2() {
    string[] menuItems = { "Старт", "Настройки", "Выход" };
    int selected = 0;
    Console.CursorVisible = false;

    while (true) {
      ShowMenu(menuItems, selected);
      ConsoleKeyInfo key = Console.ReadKey(true);
      switch (key.Key) {
        case ConsoleKey.UpArrow:
          selected = Math.Max(0, selected - 1);
          break;
        case ConsoleKey.DownArrow:
          selected = Math.Min(menuItems.Length - 1, selected + 1);
          break;
        case ConsoleKey.Enter:
          Console.Clear();
          Console.WriteLine($"Выбрано: {menuItems[selected]}");
          return;
      }
    }
  }

  static void Timer() {
    Console.WriteLine("Таймер (P: пауза/продолжить, Esc: выход)");

    DateTime lastPrint = DateTime.Now;
    bool isPaused = false;
    bool exit = false;

    while (!exit) {
      // Обработка клавиш 
      if (Console.KeyAvailable) {
        var key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.P) isPaused = !isPaused;
        if (key == ConsoleKey.Escape) exit = true;
      }

      // Проверка времени
      if (!isPaused && (DateTime.Now - lastPrint).TotalMilliseconds >= 500) {
        Console.WriteLine(DateTime.Now.ToString("HH:mm:ss.fff"));
        lastPrint = DateTime.Now;
      }

      // Небольшая задержка для снижения нагрузки на CPU
      System.Threading.Thread.Sleep(50);
    }
  }
}