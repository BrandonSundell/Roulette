using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    public class Wheel
    {
        //created a random for the ball
        public static Random ball = new Random();
        //created a wheel
        public static Tuple<int, string>[] wheel =
            {
            Tuple.Create(0, "green"), //index [0]
            Tuple.Create(00, "green"), //index [1]
            Tuple.Create(1, "red"), //index [2]
            Tuple.Create(2, "black"), //index [3]
            Tuple.Create(3, "red"), //index [4]
            Tuple.Create(4, "black"), //index [5]
            Tuple.Create(5, "red"), //index [6]
            Tuple.Create(6, "black"), //index [7]
            Tuple.Create(7, "red"), //index [8]
            Tuple.Create(8, "black"), //index [9]
            Tuple.Create(9, "red"), //index [10]
            Tuple.Create(10, "black"), //index [11]
            Tuple.Create(11, "black"), //index [12]
            Tuple.Create(12, "red"), //index [13]
            Tuple.Create(13, "black"), //index [14]
            Tuple.Create(14, "red"), //index [15]
            Tuple.Create(15, "black"), //index [16]
            Tuple.Create(16, "red"), //index [17]
            Tuple.Create(17, "black"), //index [18]
            Tuple.Create(18, "red"), //index [19]
            Tuple.Create(19, "red"), //index [20]
            Tuple.Create(20, "black"), //index [21]
            Tuple.Create(21, "red"), //index [23]
            Tuple.Create(22, "black"), //index [24]
            Tuple.Create(23, "red"), //index [25]
            Tuple.Create(24, "black"), //index [26]
            Tuple.Create(25, "red"), //index [27]
            Tuple.Create(26, "black"), //index [28]
            Tuple.Create(27, "red"), //index [29]
            Tuple.Create(28, "black"), //index [30]
            Tuple.Create(29, "black"), //index [31]
            Tuple.Create(30, "red"), //index [32]
            Tuple.Create(31, "black"), //index [33]
            Tuple.Create(32, "red"), //index [34]
            Tuple.Create(33, "black"), //index [35]
            Tuple.Create(34, "red"), //index [36]
            Tuple.Create(35, "black"), //index [37]
            Tuple.Create(36, "red"), //index [38]
            };
        //Method to show the user the options for bets
        public static void PrintWheel()
        {
            Console.WriteLine("Welcome to Roulette!");
            for (int i = 0; i < wheel.Length; i++)
            {
                Console.WriteLine(wheel[i]);
            }
            Console.WriteLine("This is the Wheel! You will be using this to make your bets!");
        }
        //Method to return a random value of the wheel tuple array
        public static Tuple<int, string> SpinWheel()
        {
            Console.WriteLine("Hit enter to spin the wheel!");
            Console.ReadLine();
            int output = ball.Next(0, wheel.Length - 1);
            Tuple<int, string> ballLands = wheel[output];
            return ballLands;
        }
    }
}
