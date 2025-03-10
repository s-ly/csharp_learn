using System;

namespace App;

public static class Symbol {
  public const string empty = "";
  public const string space = " ";
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
