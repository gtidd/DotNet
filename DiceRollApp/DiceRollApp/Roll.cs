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
    class Roll
    {
       private Random diceRoll = new Random(); //creates object of class Random

       private int[] firstDice = new int[100]; //creates two arrays one for each dice
       private int[] secondDice= new int[100];

        public int DiceOne()
        {
            return diceRoll.Next(6)+1; //six sided die
        }
        public int DiceTwo()
        {
            return diceRoll.Next(6) + 1;
        }
        public void RollDice()
        {
            for (int i = 0; i <= 100; i++)
            {
                int one = DiceOne(); //rolls die
                int two = DiceTwo();

                if (one == two)
                {
                    Console.WriteLine("{0}\t {1}\t {2}", i, one, two ); // only prints out when numbers are identical
                }
            }
                  
        }
    }
}
