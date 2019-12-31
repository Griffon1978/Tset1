using System;
using System.Collections.Generic;

namespace GameApp1
{
    class Program
    {
        public static List<string> Left { get; private set; }
        public static List<string> Right { get; private set; }

        static void Main(string[] args)
        {
            new List<string>();

            while (true)
            {
                Console.WriteLine("Dashing around a corner, away from The Beast, you see 2 doors." +
                    "Which door do you choose? Type: Left or Right");

                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                else if (input == "Left")
                    Console.WriteLine("YOU ARE DEAD");
                else if (input == "Right")
                    Console.WriteLine("YOU GOT AWAY");

                Console.WriteLine("Catching your breath, you see 2 weapons, an Axe and a Sword." +
                    "Type: Axe or Sword");

                input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                else if (input == "Axe")
                    Console.WriteLine("Gimli's Power Axe, + 5 DMG");
                else if (input == "Sword")
                    Console.WriteLine("Aragorn's Sword of Light, + 5 DEX");
                

            }

            
            
        }

    }
}
