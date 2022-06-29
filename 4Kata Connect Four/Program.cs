using System;
using System.Collections.Generic;

namespace _4Kata_Connect_Four
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>()
            {
                "A_Red",
                "B_Yellow",
                "A_Red",
                "B_Yellow",
                "A_Red",
                "B_Yellow",
                "G_Red",
                "B_Yellow"
            };
        }
    }
    public class ConnectFour
    {
        public static string WhoIsWinner(List<string> piecesPositionList)
        {

            return "Red"; //or "Yellow" or "Draw"
        }
        private static int TranslateNumberColumn(List<string> piecesPositionList, int numberList)
        {
            char letterColumns = piecesPositionList[numberList][0];
            switch (letterColumns)
            {
                case 'A': return 0;
                case 'B': return 1;
                case 'C': return 2;
                case 'D': return 3;
                case 'E': return 3;
                case 'F': return 5;
                case 'G': return 6;
                default: throw new ArgumentException("Wrong columns letter");
            }
        }

        private static int TranslateColor(List<string> piecesPositionList, int numberList)
        {
            string color = piecesPositionList[numberList].Split('_')[1];
            switch (color)
            {
                case "Red": return 0;
                case "Yellow": return 1;
                default: throw new ArgumentException("Wrong color");
            }
        }
        private static 
    }

}
