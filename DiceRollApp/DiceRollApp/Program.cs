/* 
Gregory Tidd
POS/409
4/2/16
 Marion Mishoe
Dice Roll app week 1 individual 1.0 
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Roll toss = new Roll(); //creates new object of class Roll 
            Console.WriteLine("Index | Die One | Die Two");
            toss.RollDice();        //access method from class Roll to Roll Dice
        }
    }
}
