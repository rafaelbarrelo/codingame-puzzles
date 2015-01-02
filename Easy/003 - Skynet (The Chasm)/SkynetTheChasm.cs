//Puzzle - Skynet - The Chasm
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player
{
    static void Main(String[] args)
    {
        int R = int.Parse(Console.ReadLine()); // the length of the road before the gap.
        int G = int.Parse(Console.ReadLine()); // the length of the gap.
        int L = int.Parse(Console.ReadLine()); // the length of the landing platform.

        //Console.Error.WriteLine(string.Format("R:{0} > G:{1} > L:{2}", R, G, L));

        bool jump = false;
        // game loop
        while (true)
        {
            int S = int.Parse(Console.ReadLine()); // the motorbike's speed.
            int X = int.Parse(Console.ReadLine()); // the position on the road of the motorbike.

            if(!jump){
                if(X < R-1)
                {
                    int gapJump = G+1;
                    if(S < gapJump) {
                        Console.WriteLine("SPEED"); // A single line containing one of 4 keywords: SPEED, SLOW, JUMP, WAIT.
                    }
                    else if(S > gapJump){
                        Console.WriteLine("SLOW");
                    }
                    else {
                        Console.WriteLine("WAIT");
                    }
                }else{
                    Console.WriteLine("JUMP"); // A single line containing one of 4 keywords: SPEED, SLOW, JUMP, WAIT.
                    jump = true;
                }    
            }else{
                Console.WriteLine("SLOW");
            }
        }
    }
}