using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOneConsoleAppLogic
{
    public static class MathHelper
    {
        //define a function that takes in a number that is an integer and returns the square of that integer

        //in mathhelper
        //cubing function
        //fourth power function
        //division function - takes in 2 arguments - both ints - should return either a float or a double

        public static int SquareInput(int input)
        {
            int result = 0;
            result = input * input;
            return result;
        }

        public static int CubeInput(int input)
        {
            int result = 0;
            result = input * input * input;
            return result;
        }

        public static int FourthPower(int input)
        {
            int result = 0;
            result = input * input * input * input;
            return result;
        }

        public static double Division(int numerator, int denominator)
        {
            double result = 0;

            while (denominator <= numerator)
            {
                numerator = numerator - denominator;
                result++;
            }

            return result;
        }

        public static double Quotient(int numerator, int denominator)
        {
            double result = 0;
            result = (double)numerator / (double)denominator;
            return result;
        }

        public static int[,] CreateMatrix(int rows, int columns)
        {
            int[,] tempArray = new int[rows, columns];
            return tempArray;
        }

        public static T[,] CreateGenericMatrix<T>(int rows, int columns)
        {
            T[,] tempArray = new T[rows, columns];
            return tempArray;
        }

    }
}
