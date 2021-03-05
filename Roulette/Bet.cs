using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Bet
    {
        //Method to take player bet type
        public static string GetInput() => Console.ReadLine().ToLower();

        public static void GetBetType()
        {
            Console.WriteLine("Try your luck and Place your bet!!");
            Console.WriteLine("Choose bet type: Black, Red, Even, Odd, Low, High, Dozens, Columns, Street, 6 Number, Split, Corner, Single");
            //Loop for input validation --Andrew Hejl
            string betType = "";
            betType = GetInput();
            Tuple<int, string> wheelLands;
            for (; ; )
            {

                switch (betType)
                {
                    case "black":
                    case "red":
                        Console.WriteLine($"Your bet type was: {betType}. You have a 47.37% chance of winning!");
                        wheelLands = Wheel.SpinWheel();
                        CheckWin.CheckRedBlack(wheelLands, betType);
                        return;

                    case "even":
                    case "odd":
                        Console.WriteLine($"Your bet type was: {betType}. You have a 47.37% chance of winning!");
                        wheelLands = Wheel.SpinWheel();
                        CheckWin.CheckEvenOdd(wheelLands, betType);
                        return;

                    case "low":
                    case "high":
                        Console.WriteLine($"Your bet type was: {betType}. You have a 47.37% chance of winning!");
                        wheelLands = Wheel.SpinWheel();
                        CheckWin.CheckLowHigh(wheelLands, betType);
                        return;

                    case "single":
                        Console.WriteLine($"Your bet type was: {betType}. You have a 2.63% chance of winning!");
                        wheelLands = Wheel.SpinWheel();
                        CheckWin.CheckSingle(wheelLands, betType);
                        return;

                    //case "dozens":
                    //    Console.WriteLine($"Your bet type was: {betType}. You have a 31.58% chance of winning!");
                    //    return;

                    //case "columns":
                    //    Console.WriteLine($"Your bet type was: {betType}. You have a 31.58% chance of winning!");
                    //    return;

                    //case "street":
                    //    Console.WriteLine($"Your bet type was: {betType}. You have a 7.89% chance of winning!");
                    //    return;

                    //case "6 numbers":
                    //    Console.WriteLine($"Your bet type was: {betType}. You have a 15.79% chance of winning!");
                    //    return;

                    //case "split":
                    //    Console.WriteLine($"Your bet type was: {betType}. You have a 5.26% chance of winning!");
                    //    return;

                    //case "corner":
                    //    Console.WriteLine($"Your bet type was: {betType}. You have a 10.53% chance of winning!");
                    //    return;

                    default:
                        Console.WriteLine("BetType not valid start over.");
                        betType = GetInput();
                        break;
                }

            }
        }
    }
}
