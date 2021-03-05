using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class CheckWin
    {
        //public static string WinLoseMsg(Tuple<int, string> ballLands, bool winner)
        //{
        //    if (winner == true)
        //    {
        //        return $"The ball landed on {ballLands}! You won! ";
        //    }
        //    else
        //    {
        //        return $"The ball landed on {ballLands}! You Lost! ";
        //    }
        //}
        //method to check the second item in ballLands is equal to the string betType
        public static bool CheckRedBlack(Tuple<int, string> ballLands, string betType)
        {
            bool winner = false;
            if (ballLands.Item2 == betType)
            {
                winner = true;
                Console.WriteLine($"The ball landed on {ballLands}! You won! ");
            }
            else
            {
                Console.WriteLine($"The ball landed on {ballLands}! You Lost! ");
            }
            return winner;
        }
        //method to compare the if number the ballLands on the wheel is Even or Odd
        public static bool CheckEvenOdd(Tuple<int, string> ballLands, string betType)
        {
            bool winner = false;
            if (ballLands.Item1 % 2 == 0 && betType == "even")
            {
                winner = true;
                Console.WriteLine($"The ball landed on {ballLands}! You won! ");
            }
            if (ballLands.Item1 % 2 != 0 && betType == "odd")
            {
                winner = true;
                Console.WriteLine($"The ball landed on {ballLands}! You won! ");
            }
            else
            {
                Console.WriteLine($"The ball landed on {ballLands}! You lost! ");
            }
            return winner;
        }

        public static bool CheckLowHigh(Tuple<int, string> ballLands, string betType)
        {
            bool winner = false;
            if (ballLands.Item1 >= 19 && betType == "high" && ballLands.Item1 != 0)
            {
                winner = true;
                Console.WriteLine($"The ball landed on {ballLands}! You won! ");
            }
            else if (ballLands.Item1 <= 18 && betType == "low" && ballLands.Item1 != 0)
            {
                winner = true;
                Console.WriteLine($"The ball landed on {ballLands}! You won! ");
            }
            else
            {
                Console.WriteLine($"The ball landed on {ballLands}! You lost! ");
            }
            return winner;
        }

        public static bool CheckSingle(Tuple<int, string> ballLands, string betType)
        {
            bool winner = false;
            Tuple<int, string> playerSingleBet;
            Console.WriteLine("Input the number for your single bet!");
            int playerNum = Int32.Parse(Console.ReadLine());
            if (playerNum <= 36 && playerNum > 0)
            {
                foreach (Tuple<int, string> bet in Wheel.wheel)
                {
                    if (bet.Item1 == playerNum)
                    {
                        playerSingleBet = bet;
                        Console.WriteLine($"Your bet was ({playerSingleBet.Item1}, {playerSingleBet.Item2})!");
                        if (playerSingleBet.Item1 == ballLands.Item1)
                        {
                            winner = true;
                            Console.WriteLine($"The ball landed on {ballLands}! You won! ");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"The ball landed on {ballLands}! You lost! ");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid number! Try again");
                CheckSingle(ballLands, betType);
            }
            return winner;
        }

    }
}
