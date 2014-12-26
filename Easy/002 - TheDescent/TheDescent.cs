//Puzzle - Kirk's Quest - The Descent

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {

        // game loop
        while (true)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int SX = int.Parse(inputs[0]);
            int SY = int.Parse(inputs[1]);
            
            int fire = 0;
            int last = 0;
            for (int i = 0; i < 8; i++)
            {
                int MH = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0. Mountain heights are provided from left to right.
                if(MH > last){
                    last = MH;
                    fire = i;
                }
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            if (SX == fire)
                Console.WriteLine("FIRE");
            else
                Console.WriteLine("HOLD"); // either:  FIRE (ship is firing its phase cannons) or HOLD (ship is not firing).
        }
    }
}
