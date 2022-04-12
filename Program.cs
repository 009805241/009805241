using System;
using System.Threading;

// TO DO:
// 1. program generates a random number between 1 and 6.
// 2. program can optionally generate a selectable amount of numbers between 1 and 6.

namespace DxE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dice x Emulator\n");
            Console.Title = "DxE";

            //Console.TreatControlCAsInput = true;
            ConsoleKeyInfo UserInput;

            Console.WriteLine("Press Escape to quit. \nPress R to roll \nS for settings");

            do
            {
                UserInput = Console.ReadKey();
                if (UserInput.Modifiers == ConsoleModifiers.Alt) Console.WriteLine("ALT ");
                if (UserInput.Modifiers == ConsoleModifiers.Control) Console.WriteLine("CONTROL ");
                if (UserInput.Modifiers == ConsoleModifiers.Shift) Console.WriteLine("SHIFT ");

                switch (UserInput.Key)
                {
                    case ConsoleKey.R:
                        Dice.RollDice();
                        break;

                    case ConsoleKey.S:
                        Dice.SettingsMenu();
                        break;
                }
            } while (UserInput.Key != ConsoleKey.Escape);
        }
    }
}
