using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            int myInt = 0; //just for testing single stepping
            string myString = "12"; //watch me being cast from string to int
            int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int

            //MAIN:  NUMBER CONVERSION PROGRAM
            Console.WriteLine(numberConversion(480, 68));
            string one = "animal";
            string two = "123";
            string combined = one + two;
            Console.WriteLine(combined);
            //CODE GOES HERE

            string binaryNumber = " ";

            Console.WriteLine("Enter a number");
            int number = Console.Read();
            int remainder = number % 2;
            while (remainder != 0) ;
            { 
            remainder = number % 2;
            binaryNumber = " ";
            string remainder2 = remainder.ToString();
            binaryNumber = binaryNumber + remainder2;
            number = number / 2;
        }
            while (remainder != 1) ;
            {
                
                 binaryNumber = " ";
                string remainder2 = remainder.ToString();
                binaryNumber = binaryNumber + remainder2;
                number = number / 2;
            }
             while (remainder != 0) ;
            { 
            remainder = number % 2;
            binaryNumber = " ";
            string remainder2 = remainder.ToString();
            binaryNumber = binaryNumber + remainder2;
            number = number / 2;
        } remainder = number % 2;
            Console.WriteLine(binaryNumber);
        }





        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            //CODE GOES HERE
            int calc = number + numberbase;
            string result = calc.ToString();

            return result; //REMOVE THE RED LINE!


            {
               
            }
        }
    }
}
