using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string TEMPS = Console.ReadLine(); // the N temperatures expressed as integers ranging from -273 to 5526
        
        //Console.Error.WriteLine(TEMPS);
        if (TEMPS == null) {
            Console.WriteLine(0); 
            return;
        }
        
        string[] valores = TEMPS.Split(' ');
        int closer = int.Parse(valores[0]);
        //Console.Error.WriteLine("closer: "+ closer);
        
        foreach (string v in valores){
            int x = int.Parse(v);
            //Console.Error.WriteLine("X: "+ x);
            if (x > 0){
                closer = (x > closer) && (x > (closer * -1)) ? closer : x;
            }  
            else if(x < 0){
                closer = x < closer ? closer : x;
            }
            else{
                Console.WriteLine(0);
            }
        }
        Console.WriteLine(closer);
    }
}