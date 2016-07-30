using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace DieRollAppWindowsForm
{
    class Roll
    {
        private Random diceRoll = new Random(); //creates object of class Random

        private ListView lvDieDouble = new ListView();


        private int[] firstDice = new int[100]; //creates four arrays one for each dice
        private int[] secondDice = new int[100];
        private int[] thirdDice = new int[100];
        private int[] fourthDice = new int[100];

        

        public int DiceOne()
        {
            return diceRoll.Next(6) + 1; //six sided die
        }
        public int DiceTwo()
        {
            return diceRoll.Next(6) + 1;
        }
        public int DiceThree()
        {
            return diceRoll.Next(6) + 1;
        }
        public int DiceFour()
        {
            return diceRoll.Next(6) + 1;
        }
        public void RollDice()
        {
            for (int i = 0; i <= 100; i++)
            {
                int one = DiceOne(); //rolls die
                int two = DiceTwo();
                int three = DiceThree();
                int four = DiceFour();

                var dieQueryOneTwo =
                     from num in DiceOne() 
                     where num.Equals(DiceTwo())
                     select num;
                
                foreach (int num in dieQueryOneTwo)
                {
                    lvDieDouble.Items.Add(num.ToString());

                }
                var dieQueryThreeFour =
                     from num in DiceThree()
                     where num.Equals(DiceFour())
                     select num;

                foreach (int num in dieQueryThreeFour)
                {
                    lvDieDouble.Items.Add(num.ToString());

                }

       
            }

        }
    }
}
