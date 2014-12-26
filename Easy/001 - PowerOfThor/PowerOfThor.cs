//Puzzle - Ragnarök - Power of Thor

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
        string[] inputs = Console.ReadLine().Split(' ');
        int LX = int.Parse(inputs[0]); // the X position of the light of power
        int LY = int.Parse(inputs[1]); // the Y position of the light of power
        int TX = int.Parse(inputs[2]); // Thor's starting X position
        int TY = int.Parse(inputs[3]); // Thor's starting Y position
        
        // game loop
        while (true)
        {
            int E = int.Parse(Console.ReadLine()); // The level of Thor's remaining energy, representing the number of moves he can still make.

            //Console.Error.WriteLine("TY=" + TY + "  TX=" + TX);

            if(LY == TY && LX > TX){
                Console.WriteLine("E");
            }
            else if(LY == TY && LX < TX){
                Console.WriteLine("W");
            }
            else if (LY > TY && LX == TX){
                Console.WriteLine("S");   
            }
            else if (LY < TY && LX == TX){
                Console.WriteLine("N");
            }
            else if(LY > TY && LX > TX){
                Console.WriteLine("SE");
                TY++;
                TX++;
            }
            else if(LY > TY && LX < TX){
                Console.WriteLine("SW");
                TY++;
                TX--;
            }
            else if (LY < TY && LX > TX){
                Console.WriteLine("NE");
                TY--;
                TX++;
            }
            else if (LY < TY && LX > TX){
                Console.WriteLine("NW");
                TY--;
                TX--;
            }
        }
    }
}
