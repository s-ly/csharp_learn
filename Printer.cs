using System;

namespace App;

public class Printer {
  public static void PrintTest() {
    Console.CursorVisible = false;
    Console.Clear();
    PrintBoard(sizeX: 20, sizeY: 10);
    Console.CursorVisible = true;
  }
  public static void PrintBoard(int sizeX = 2, int sizeY = 2) {
    string strLine = "│";
    string strSpace = " ";
    string strComp = "";

    Console.SetCursorPosition(left: 0, top: 0);

    strComp += "┌";
    for (int i = 0; i < sizeX - 2; i++) {
      strComp += "─";
    }
    strComp += "┐";
    Console.WriteLine(strComp);

    strComp = "";
    strComp += strLine;
    for (int i = 0; i < sizeX - 2; i++) {
      strComp += strSpace;
    }
    strComp += strLine;
    // Console.WriteLine(strComp);
    for (int i = 0; i < sizeY - 2; i++) {
      Console.WriteLine(strComp);
    }
    strComp = "";
    strComp += "└";
    for (int i = 0; i < sizeX - 2; i++) {
      strComp += "─";
    }
    strComp += "┘";
    Console.WriteLine(strComp);
    Console.WriteLine("██ ▓▓ ▒▒ ░░ ▩");


  }
}
