using System;

namespace App;

public static class Symbol {
  public const string empty = "";
  public const string space = " ";
  public const string star = "*";
  public const string openSquareBracket = "[";
  public const string closeSquareBracket = "]";
  public const string horizontalLine = "─";
  public const string verticalLine = "│";
  public const string cornerLeftTop = "┌";
  public const string cornerLeftBottom = "└";
  public const string cornerRightTop = "┐";
  public const string cornerRightBottom = "┘";
  public const string blockHigh = "█";
  public const string blockMedium = "▓";
  public const string blockLow = "▒";
  public const string blockVeryLow = "░";
}

public class Pixel {
  public string SymbolFirst { get; set; } = Symbol.openSquareBracket;
  public string SymbolSecond { get; set; } = Symbol.closeSquareBracket;
  // public int X { get; set; }
  // public int Y { get; set; }

  // public void SetPixelLocal(int x, int y) {
  //   X = x;
  //   Y = Y;
  // }

  public void SetPixelSymbol(string symbolFirst = Symbol.space, string symbolSecond = Symbol.space) {
    SymbolFirst = symbolFirst;
    SymbolSecond = symbolSecond;
  }
}

public class Screen {
  const int minSizeX = 2;
  const int minSizeY = 2;

  public int SizeX { get; set; }
  public int SizeY { get; set; }
  public Pixel[,] field; // двуменрный массив пикселей

  public Screen() {
    SizeX = minSizeX;
    SizeY = minSizeY;

    field = new Pixel[SizeX, SizeY];
    for (int i = 0; i < SizeY; i++) {
      for (int j = 0; j < SizeX; j++) {
        field[i, j] = new Pixel();
      }
    }
  }

  public Screen(int size) {
    SizeX = size;
    SizeY = size;

    field = new Pixel[SizeX, SizeY];
    for (int i = 0; i < SizeY; i++) {
      for (int j = 0; j < SizeX; j++) {
        field[i, j] = new Pixel();
      }
    }
  }

  public void Draw() {
    Console.Clear();
    // Console.CursorVisible = false;
    DrawScreen();
    // Console.CursorVisible = true;
  }

  public void DrawScreen() {
    string line = "";
    for (int i = 0; i < SizeY; i++) {
      for (int j = 0; j < SizeX; j++) {
        line += field[i, j].SymbolFirst + field[i, j].SymbolSecond;
      }
      Console.WriteLine(line);
      line = "";
    }
  }

  public void MakePoint(int x = 1, int y = 1) {
    Pixel pixel = new Pixel();
    pixel.SetPixelSymbol(Symbol.blockHigh, Symbol.blockHigh);
    field[y - 1, x - 1] = pixel;
  }

  /// <summary>
  /// Заполняет экран выбранным пикселем.
  /// </summary>
  public void Fill(Pixel pixel) {
    for (int i = 0; i < SizeY; i++) {
      for (int j = 0; j < SizeX; j++) {
        field[i, j] = pixel;
      }
    }
  }

  public void Clear() {
    Pixel pixel = new Pixel();
    pixel.SetPixelSymbol(Symbol.space, Symbol.space);
    Fill(pixel);
  }

}


























public class Printer {
  const int defaultMiniSizeField = 2;

  public int Rows { get; set; }
  public int Columns { get; set; }
  public int[,] Field { get; set; }

  public Printer() {
    Rows = defaultMiniSizeField;
    Columns = defaultMiniSizeField;
    Field = new int[Rows, Columns];
  }

  public Printer(int size) {
    Rows = size;
    Columns = size;
    Field = new int[Rows, Columns];
  }

  public Printer(int rows, int columns) {
    Rows = rows;
    Columns = columns;
    Field = new int[Rows, Columns];
  }

  public static void PrintTest() {
    Console.CursorVisible = false;
    Console.Clear();
    PrintBoard(sizeX: 20, sizeY: 10);
    Console.CursorVisible = true;
  }

  public void PrintField() {
    for (int r = 0; r < Rows; r++) {
      for (int c = 0; c < Columns; c++) {
        Console.Write(c);
      }
      Console.WriteLine();
    }
  }

  public void PrintAll() {
    Console.CursorVisible = false;
    Console.Clear();
    // PrintBoard(sizeX: 20, sizeY: 10);
    PrintField();
    Console.CursorVisible = true;
  }

  public static void PrintBoard(int sizeX = 2, int sizeY = 2) {
    Console.SetCursorPosition(left: 0, top: 0);
    string strComp = Symbol.empty;
    strComp += Symbol.cornerLeftTop;
    for (int i = 0; i < sizeX - 2; i++) {
      strComp += Symbol.horizontalLine;
    }
    strComp += Symbol.cornerRightTop;
    Console.WriteLine(strComp);

    strComp = Symbol.empty;
    strComp += Symbol.verticalLine;
    for (int i = 0; i < sizeX - 2; i++) {
      strComp += Symbol.space;
    }
    strComp += Symbol.verticalLine;
    for (int i = 0; i < sizeY - 2; i++) {
      Console.WriteLine(strComp);
    }
    strComp = Symbol.empty;
    strComp += Symbol.cornerLeftBottom;
    for (int i = 0; i < sizeX - 2; i++) {
      strComp += Symbol.horizontalLine;
    }
    strComp += Symbol.cornerRightBottom;
    Console.WriteLine(strComp);
  }
}
