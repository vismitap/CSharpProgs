using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fellowship_CSharp_Programs.LogicalProg
{
    public class Gambler
    {
        public void SimulateGamblerProblem()
        {
            Console.WriteLine("Enter the number of times you want to run the experiment");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Stake");
            int stake = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Goal");
            int goal = Convert.ToInt32(Console.ReadLine());

            int stakeRemaining = stake;
            int betWinCount = 0; //bet win count
            bool didWin = false; //overall win
            int noOfTimesRun = 0; 

 
            while(num > 0 || stakeRemaining != 0 || didWin )
            {
                Random random = new Random();
                int RESULT = random.Next(0, 2); //1 for win and 0 for lost

                stakeRemaining--; // decrement 1 for bet amount

                if (RESULT == 0) //bet lost
                {
                    stakeRemaining -= 2; // decrement 2 if bet is lost
                }
                else //bet won
                {
                    betWinCount++;
                    stakeRemaining += 2;
                }

                if (stakeRemaining == goal)
                {
                    didWin = true;
                }
                noOfTimesRun++;
                num--;
            }
            double percentWin = ((double) betWinCount / noOfTimesRun) * 100;
            double percentLoss = 100 - percentWin;

            Console.WriteLine("The total no of Bet Wins are: "+betWinCount+"\n Percentage Win: "+ percentWin+"\n Percentage Loss: "+percentLoss);

        }
    }
}
