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


    
                
        }





        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        static string numberConversion(int number, int numberbase)
        {
            
string result = " ";

            int remainder = 0;

            int count = 0;

            int[] binary = new int[32];

            while (number > 0)

            {

                remainder = number % numberbase;

                number = number / numberbase;

                binary[count] = remainder;

                count = count + 1;

            }

            for (int j = count - 1; j >= 0; j--)

            {

                Console.Write(binary[j]);

            }

         

            return result; //REMOVE THE RED LINE!


            {
               
            }
        }
    }
}
