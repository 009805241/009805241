using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxE
{
    internal class Dice
    {
        static Random DiceRoller = new Random();
        public static List<int> DiceRolls = new List<int>() { };
        static int DiceAmount = 1;

        static int min = 1;
        static int max = 6;

        // NUMBER GENERATING METHOD FOR DICE //

        public static void RollDice()
        {
            Console.WriteLine("\nRolling...");
            for (int i = 0; i < DiceAmount; i++)
            {
                DiceRolls.Add(DiceRoller.Next(min, max));
            }

            Thread.Sleep(300);
            Console.Write("Rolled: ");

            for (int i = 0; i < Dice.DiceRolls.Count; i++)
            {
                Console.Write($" {Dice.DiceRolls[i]}");
            }
            DiceRolls.Clear();
            Console.WriteLine();
        }
        // CHANGING THE TYPE OF DICE //

        public static void ChangeDiceType()
        {
            Console.WriteLine($"\nCurrent dice results range from {min} to {max}.");
            Console.WriteLine(" Set maximum value to:");
            string input = Console.ReadLine();
            max = Int32.Parse(input);
            Console.WriteLine(string.Format("Maximum dice value set to {0}", max));
        }

        // CHANGING THE AMOUNT OF DICE //

        public static void SetDiceAmount()
        {
            Console.Write("\nSet the amount of dice to: ");
            DiceAmount = Int32.Parse(Console.ReadLine());
            Console.Write($"Dice amount set to {DiceAmount}\n");
        }

        // SETTINGS MENU //
        public static void SettingsMenu()
        {
            Console.WriteLine("\n1. Set dice amount");
            Console.WriteLine("2. Set dice type");

            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.D1:
                    SetDiceAmount();
                    break;
                case ConsoleKey.D2:
                    ChangeDiceType();
                    break;
            }


        }
    }
}
