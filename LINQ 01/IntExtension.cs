using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_01
{
    internal static class IntExtension
    {
        //Extension Methods
        public static int Reverse(this int Number)
        {
            int ReversedNumber = 0, LastDigit;

            while (Number > 0)
            {
                LastDigit = Number % 10;
                ReversedNumber = ReversedNumber * 10 + LastDigit;
                Number /= 10;

            }

            return ReversedNumber;


        }



        //public static double Reverse(this double Number)
        //{
        //    double ReversedNumber = 0, LastDigit;

        //    while (Number > 0)
        //    {
        //        LastDigit = Number % 10;
        //        ReversedNumber = ReversedNumber * 10 + LastDigit;
        //        Number /= 10;

        //    }

        //    return ReversedNumber;


        //}


        // 12345 % 10 = 5

        // 12345 /10 = 1234

        // 1234 % 10 = 4

        // 1234 / l0 = 123

        // 123 % 10 = 3
        // 123 / 10 = 12

        // 12 % 10 = 2

        // 12 / 10 = 1

        //1 % 10 = 1

        //1 / 10 = 0








        // ReverseNumber : 54321

    }
}
