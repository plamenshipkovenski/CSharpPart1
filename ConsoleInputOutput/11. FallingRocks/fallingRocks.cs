using System;
using System.Collections.Generic;
using System.Threading;

class FallingRocks
{
    struct GameObject 
    {
        public int x;
        public int y;
        public char rockSymbol;
        public string dwarfLook;
        public ConsoleColor color;
    }

    static void PrintRockOnPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.White)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }

    static void PrintDwarfOnPosition(int x, int y, string dwarfLook, ConsoleColor color = ConsoleColor.White)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(dwarfLook);
    }

    static void Main()
    {
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 30;
        char[] rocksLook = new char[]{'^','@', '*', '&', '+','%', '$', '#', '!', '.', ';'};
        GameObject dwarf = new GameObject();
        dwarf.dwarfLook = "(0)";
        dwarf.x = Console.WindowWidth / 2;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.color = ConsoleColor.Green;
        List<GameObject> rocks = new List<GameObject>();
        Random randomGenerator = new Random();

        while (true)
        {
            //move dwarf(key pressed)
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyPressed = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);
                if (keyPressed.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0)
                    {
                        dwarf.x = dwarf.x - 1;
                    }
                }
                else if (keyPressed.Key == ConsoleKey.RightArrow)
                {
                    if ((dwarf.x + dwarf.dwarfLook.Length) + 1 < Console.WindowWidth)
                    {
                        dwarf.x = dwarf.x + 1;
                    }
                }
            }
            //move rocks
            //check if dwarf is hitted

            //clear console
            Console.Clear();

            //redraw playfield
            PrintDwarfOnPosition(dwarf.x, dwarf.y, dwarf.dwarfLook, dwarf.color);

            //draw info

            //slow program
            Thread.Sleep(150);
        }
    }
}
